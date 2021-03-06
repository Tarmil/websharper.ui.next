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
        (lm: ListModel<'K,'T>, f: Func<'T, bool>) = lm.RemoveBy (FSharpConvert.Fun f)
    
    [<Extension; Inline>]
    static member Iter<'K,'T when 'K : equality>
        (lm: ListModel<'K,'T>, f: Func<'T, unit>) = lm.Iter (FSharpConvert.Fun f)

    [<Extension; Inline>]
    static member Find<'K,'T when 'K : equality>
        (lm: ListModel<'K,'T>, f: Func<'T, bool>) = lm.Find (FSharpConvert.Fun f)

    [<Extension; Inline>]
    static member TryFind<'K,'T when 'K : equality>
        (lm: ListModel<'K,'T>, f: Func<'T, bool>) = lm.TryFind (FSharpConvert.Fun f)

    [<Extension; Inline>]
    static member FindAsView<'K,'T when 'K : equality>
        (lm: ListModel<'K,'T>, f: Func<'T, bool>) = lm.FindAsView (FSharpConvert.Fun f)

    [<Extension; Inline>]
    static member TryFindAsView<'K,'T when 'K : equality>
        (lm: ListModel<'K,'T>, f: Func<'T, bool>) = lm.TryFindAsView (FSharpConvert.Fun f)

    [<Extension; Inline>]
    static member UpdateAll<'K,'T when 'K : equality>
        (lm: ListModel<'K,'T>, f: Func<'T, 'T option>) = lm.UpdateAll (FSharpConvert.Fun f)

    [<Extension; Inline>]
    static member UpdateBy<'K,'T when 'K : equality>
        (lm: ListModel<'K,'T>, key, f: Func<'T, 'T option>) = lm.UpdateByU (FSharpConvert.Fun f, key)

    [<Extension; Inline>]
    static member LensInto<'K,'T,'V when 'K : equality>
        (lm: ListModel<'K,'T>, key, get: Func<'T,'V>, set: Func<'T,'V,'T>) =
        lm.LensIntoU (FSharpConvert.Fun get, FSharpConvert.Fun set, key)

    [<Extension; Inline>]
    static member Map(lm: ListModel<'K, 'T>, f: Func<'T, 'V>) = 
        View.MapSeqCachedBy lm.Key (FSharpConvert.Fun f) lm.ViewState

    [<Extension; Inline>]
    static member Map(lm: ListModel<'K, 'T>, f: Func<'K, View<'T>, 'V>) = 
        View.MapSeqCachedViewBy lm.Key (FSharpConvert.Fun f) lm.ViewState
