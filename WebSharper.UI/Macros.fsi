﻿// $begin{copyright}
//
// This file is part of WebSharper
//
// Copyright (c) 2008-2014 IntelliFactory
//
// Licensed under the Apache License, Version 2.0 (the "License"); you
// may not use this file except in compliance with the License.  You may
// obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
// implied.  See the License for the specific language governing
// permissions and limitations under the License.
//
// $end{copyright}

namespace WebSharper.UI

module internal Macros =
    [<Class>] type V = inherit WebSharper.Core.Macro
    [<Class>] type LensFunc = inherit WebSharper.Core.Macro
    [<Class>] type VProp = inherit WebSharper.Core.Macro
    [<Class>] type TextView = inherit WebSharper.Core.Macro
    [<Class>] type AttrCreate = inherit WebSharper.Core.Macro
    [<Class>] type AttrStyle = inherit WebSharper.Core.Macro
    [<Class>] type ElementMixed = inherit WebSharper.Core.Macro
    [<Class>] type DocConcatMixed = inherit WebSharper.Core.Macro
    [<Class>] type LensMeth = inherit WebSharper.Core.Macro
    [<Class>] type InputV = inherit WebSharper.Core.Macro
