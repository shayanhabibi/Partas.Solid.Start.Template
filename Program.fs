open Fake.Core
open Fake.IO
open Farmer
open Farmer.Builders

open Helpers

initializeContext ()

let basePath = __SOURCE_DIRECTORY__
let clientPath = basePath + @"\Partas.Solid.Start.Template"

Target.create "Clean" (fun _ ->
    run fable [
        "clean"
        "-e"
        ".fs.jsx"
        "--yes"
    ] clientPath
    )

Target.create "Dev" (fun _ ->
    [
        "vinxi", npm [ "run";"dev" ] basePath
        "fable", fable [ "watch"; "-e";".fs.jsx";"--optimize"
                         // Compatibility with Partas.Solid.FablePlugin
                         "-c";"Release"
                         // Interop compatibility with most JS libraries
                         "--typedArrays";"false"
                          ] clientPath
    ] |> runParallel
    )

Target.create "Restore" (fun _ ->
    [
        "npm", npm [ "install" ] clientPath
        "dotnet", dotnet [ "restore"; "Partas.Solid.Start.Template.sln" ] basePath
    ] |> runParallel
    )

open Fake.Core.TargetOperators

let dependencies = [
    "Clean" ==> "Dev"
    "Restore"
]

[<EntryPoint>]
let main args = runOrDefault args
