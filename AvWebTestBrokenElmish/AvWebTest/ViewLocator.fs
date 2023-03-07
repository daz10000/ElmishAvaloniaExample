namespace AvWebTest

open System
open Avalonia.Controls
open Avalonia.Controls.Templates
open AvWebTest.ViewModels

(*
type ViewLocator() =
    interface IDataTemplate with

        member this.Build(data) =
            let name = data.GetType().FullName.Replace("ViewModel", "View")
            let typ = Type.GetType(name)
            if isNull typ then
                upcast TextBlock(Text = sprintf "Not Found: %s" name)
            else
                downcast Activator.CreateInstance(typ)

        member this.Match(data) = data :? ViewModelBase
        *)
type ViewLocator() =
    interface IDataTemplate with

        member this.Build(data) =
            let t = data.GetType()
            let viewName = t.FullName.Replace("ViewModels", "Views").Replace("ViewModel", "View")
            let parts = viewName.Split([|'['; '+'|], StringSplitOptions.RemoveEmptyEntries)
            let name = parts[1]
            let typ = Type.GetType(name)
            if isNull typ then
                upcast TextBlock(Text = sprintf "Not Found: %s" name)
            else
                let vm = data :?> IStart
                let view = downcast Activator.CreateInstance(typ)
                vm.Start(view)
                view

        member this.Match(data) =
            data :? IStart
