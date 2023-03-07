module AvWebTest.ViewModels.MainViewModel

open Elmish.Avalonia
type Model = {
        ContentVM : IStart
    }

type Msg =
    | Msg

let init() =
    {
        ContentVM = DNAGallery.vm
    }

let update (msg: Msg) (model: Model) =
    model

let bindings() : Binding<Model, Msg> list = [
    // Properties
    "ContentVM" |> Binding.oneWay (fun m -> m.ContentVM)
]

let designVM = ViewModel.designInstance (init()) (bindings())

let vm : IStart = Start(AvaloniaProgram.mkSimple init update bindings)

(*
type MainViewModel() =
    inherit ViewModelBase()

    member this.Greeting = "Welcome to Avalonia!"
    member this.MyItems = [| {Name="Meredith" ; Count = 56} ; {Name="Had" ; Count = 3}
                             {Name="a" ; Count = 1}
                             {Name="little" ; Count = 7} ; {Name=";lamb" ; Count = 1000} |]

*)
