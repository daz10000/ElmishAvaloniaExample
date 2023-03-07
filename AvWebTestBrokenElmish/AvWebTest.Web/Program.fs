open System.Runtime.Versioning
open Avalonia
open Avalonia.ReactiveUI
open Avalonia.Web

open AvWebTest

module Program =
    [<assembly: SupportedOSPlatform("browser")>]
    do ()

    [<CompiledName "BuildAvaloniaApp">] 
    let buildAvaloniaApp () = 
        AppBuilder
            .Configure<App>()

    [<EntryPoint>]
    let main argv =
        buildAvaloniaApp()
            .UseReactiveUI()
            .SetupBrowserApp("out")
            |> ignore
        0
