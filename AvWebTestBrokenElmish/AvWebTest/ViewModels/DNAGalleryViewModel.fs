module AvWebTest.ViewModels.DNAGallery

open Elmish.Avalonia

type DNADoc = { Name : string ; Count : int}

type Model = {
        Greeting : string
        Docs : DNADoc []
        Count : int
    }

type Msg =
    | Increment
    | Decrement
    | Reset

let init() =
    {
        Count = 100
        Greeting = "Welcome to DNACompiler!"
        Docs = [|   {Name="Meredith" ; Count = 56}
                    {Name="Had" ; Count = 3}
                    {Name="a" ; Count = 1}
                    {Name="little" ; Count = 7} ; {Name=";lamb" ; Count = 1000} |]
    }

let update (msg: Msg) (model: Model) =
    match msg with
    | Increment ->
        { model with
            Count = model.Count + 1
        }
    | Decrement ->
        { model with
            Count = model.Count - 1
        }
    | Reset ->
        init()

let bindings ()  : Binding<Model, Msg> list = [
    "Count" |> Binding.oneWay (fun m -> m.Count)
    "Greeting" |> Binding.oneWay (fun m -> m.Greeting)
    "Docs" |> Binding.oneWay (fun m -> m.Docs)
    "Increment" |> Binding.cmd Increment
    "Decrement" |> Binding.cmd Decrement
    "Reset" |> Binding.cmd Reset
]

let designVM = ViewModel.designInstance (init()) (bindings())

let vm = Start(AvaloniaProgram.mkSimple init update bindings)
