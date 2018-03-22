﻿namespace WebSharper.UI

open System
open System.Runtime.CompilerServices
open WebSharper
open WebSharper.UI

[<Extension; Class; JavaScript>]
type ModelsExtensions =

    [<Extension; Inline>]
    static member Update(model, update: Func<'M, unit>) =
        Model.Update update.Invoke model

[<Extension; Class; JavaScript>]
type ListModelExtensions =
    [<Extension; Inline>]
    static member RemoveBy<'K,'T when 'K : equality>
        (model: ListModel<'K,'T>, f: Func<'T, bool>) = model.RemoveBy (FSharpConvert.Fun f)
    
    [<Extension; Inline>]
    static member Iter<'K,'T when 'K : equality>
        (model: ListModel<'K,'T>, f: Func<'T, unit>) = model.Iter (FSharpConvert.Fun f)

    [<Extension; Inline>]
    static member Find<'K,'T when 'K : equality>
        (model: ListModel<'K,'T>, f: Func<'T, bool>) = model.Find (FSharpConvert.Fun f)

    [<Extension; Inline>]
    static member TryFind<'K,'T when 'K : equality>
        (model: ListModel<'K,'T>, f: Func<'T, bool>) = model.TryFind (FSharpConvert.Fun f)

    [<Extension; Inline>]
    static member FindAsView<'K,'T when 'K : equality>
        (model: ListModel<'K,'T>, f: Func<'T, bool>) = model.FindAsView (FSharpConvert.Fun f)

    [<Extension; Inline>]
    static member TryFindAsView<'K,'T when 'K : equality>
        (model: ListModel<'K,'T>, f: Func<'T, bool>) = model.TryFindAsView (FSharpConvert.Fun f)

    [<Extension; Inline>]
    static member UpdateAll<'K,'T when 'K : equality>
        (model: ListModel<'K,'T>, f: Func<'T, 'T option>) = model.UpdateAll (FSharpConvert.Fun f)

    [<Extension; Inline>]
    static member UpdateBy<'K,'T when 'K : equality>
        (model: ListModel<'K,'T>, key, f: Func<'T, 'T option>) = model.UpdateByU (FSharpConvert.Fun f, key)

    [<Extension; Inline>]
    static member LensInto<'K,'T,'V when 'K : equality>
        (model: ListModel<'K,'T>, key, get: Func<'T,'V>, set: Func<'T,'V,'T>) =
        model.LensIntoU (FSharpConvert.Fun get, FSharpConvert.Fun set, key)

    [<Extension; Inline>]
    static member Wrap<'K,'T,'V when 'K : equality>
        (model: ListModel<'K,'T>, extract: Func<'V,'T>, wrap: Func<'T,'V>, update: Func<'V,'T,'V>) =
        ListModel.Wrap model (FSharpConvert.Fun extract) (FSharpConvert.Fun wrap) (FSharpConvert.Fun update)

    [<Extension; Inline>]
    static member Map(model: ListModel<'K, 'T>, f: Func<'T, 'V>) = 
        View.MapSeqCachedBy model.Key (FSharpConvert.Fun f) model.ViewState

    [<Extension; Inline>]
    static member Map(model: ListModel<'K, 'T>, f: Func<'K, View<'T>, 'V>) = 
        View.MapSeqCachedViewBy model.Key (FSharpConvert.Fun f) model.ViewState

    [<Extension; Inline>]
    static member MapLens<'K,'T,'V when 'K : equality>
        (model: ListModel<'K, 'T>, f: Func<'K, Var<'T>, 'V>) =
        ListModel.MapLens (FSharpConvert.Fun f) model
