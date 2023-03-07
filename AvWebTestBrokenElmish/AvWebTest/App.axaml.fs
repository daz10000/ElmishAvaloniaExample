namespace AvWebTest

(*
open Avalonia
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.Markup.Xaml
open AvWebTest.ViewModels
open AvWebTest.Views

type App() =
    inherit Application()

    override this.Initialize() =
            AvaloniaXamlLoader.Load(this)

    override this.OnFrameworkInitializationCompleted() =
        match this.ApplicationLifetime with
        | :? IClassicDesktopStyleApplicationLifetime as desktopLifetime ->
            desktopLifetime.MainWindow <- MainWindow(DataContext = MainViewModel())
        | :? ISingleViewApplicationLifetime as singleViewLifetime ->
            singleViewLifetime.MainView <- MainView(DataContext = MainViewModel())
        | _ -> ()

        base.OnFrameworkInitializationCompleted()
*)
open Avalonia
open Avalonia.Markup.Xaml
open AvWebTest.Views
open Avalonia.Controls.ApplicationLifetimes

type App() =
    inherit Application()

    override this.Initialize() =
        // Initialize Avalonia controls from NuGet packages:
        // let dataGridType = typeof<System.Windows.Controls.DataGrid>

        AvaloniaXamlLoader.Load(this)


    override this.OnFrameworkInitializationCompleted() =
        match this.ApplicationLifetime with
        | :? IClassicDesktopStyleApplicationLifetime as desktopLifetime ->
            desktopLifetime.MainWindow <- MainWindow()// DataContext = MainViewModel())
        | :? ISingleViewApplicationLifetime as singleViewLifetime ->
            let view = MainView()
            singleViewLifetime.MainView <- view
            ViewModels.MainViewModel.vm.Start(view)
        | _ -> ()

        base.OnFrameworkInitializationCompleted()
