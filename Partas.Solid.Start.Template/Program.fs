module Partas.Solid.Start.Template.Program

open Partas.Solid
open Partas.Solid.Router
open Partas.Solid.Meta
open Partas.Solid.Start
open Fable.Core

[<Erase>]
type Render() =
    interface HtmlElement
    [<DefaultValue>]
    val mutable children: HtmlElement
    [<SolidTypeComponent>]
    member props.__ =
        Fragment() {
            MetaProvider() {
                Suspense() {
                    props.children
                }
            }
        }

[<SolidComponent>]
let Program() =
    Router(root = !@Render) {
        unbox<Route>(FileRoutes())
    }
