module Partas.Solid.Start.Template.routes.index

open Partas.Solid
open Partas.Solid.Meta
open Fable.Core

[<ExportDefault>]
[<SolidComponent>]
let private Home() =
    main() {
        Title() { "Partas.Solid.Start.Template" }
        h1() { "Partas.Solid.Start.Template" }
    }
