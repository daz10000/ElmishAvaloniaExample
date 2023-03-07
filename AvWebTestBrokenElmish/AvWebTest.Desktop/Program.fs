namespace AvWebTest.Desktop
open System
open Avalonia
// open Avalonia.ReactiveUI
open Elmish.Avalonia
open Elmish.Avalonia.AppBuilder
open AvWebTest

module Program =

    [<CompiledName "BuildAvaloniaApp">]
    let buildAvaloniaApp () =
        AppBuilder
            .Configure<App>()
            .UsePlatformDetect()
            .LogToTrace(areas = Array.empty)
            //.UseReactiveUI()
            .UseElmishBindings()


    [<EntryPoint; STAThread>]
    let main argv =
        buildAvaloniaApp().StartWithClassicDesktopLifetime(argv)
