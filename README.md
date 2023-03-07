Hacked Elmish.Avalonia for cross platform compilation and almost ootb Avalonia Web test project bolted together

Building..

One time..
```
dotnet workload install wasm-experimental wasm-tools
```

```
./build.sh
```

or

```
dotnet tool restore
dotnet paket restore
dotnet run --project AvWebTestBrokenElmish/AvWebTest.Web
```

