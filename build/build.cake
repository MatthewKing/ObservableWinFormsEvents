var target = Argument("target", "Finalize");
var configuration = Argument("configuration", "Release");
var workingDir = Directory("./temp");
var outputDir = Directory("./output");
var solutionFile = GetFiles("../*.sln").Single();

Task("Clean")
    .Does(() =>
    {
        CleanDirectory(workingDir);
        CleanDirectory(outputDir);
    });

Task("PackageRestore")
    .IsDependentOn("Clean")
    .Does(() =>
    {
        NuGetRestore(solutionFile);
    });

Task("Build")
    .IsDependentOn("PackageRestore")
    .Does(() =>
    {
        MSBuild(solutionFile, settings =>
        {
            settings.SetConfiguration(configuration);
            settings.WithProperty("OutputPath", MakeAbsolute(workingDir.Path).FullPath);
        });
    });

Task("NuGetPack")
    .IsDependentOn("Build")
    .Does(() =>
    {
        var assemblyInfoFile = File("../src/ObservableWinFormsEvents/Properties/AssemblyInfo.cs");
        var assemblyInfo = ParseAssemblyInfo(assemblyInfoFile);

        var nuspec = File("./ObservableWinFormsEvents.nuspec");

        var settings = new NuGetPackSettings();
        settings.OutputDirectory = outputDir;
        settings.Version = assemblyInfo.AssemblyInformationalVersion;
        settings.Files = new[]
        {
            new NuSpecContent() { Source = workingDir + File("./ObservableWinFormsEvents.dll"), Target = "lib/net45" },
            new NuSpecContent() { Source = workingDir + File("./ObservableWinFormsEvents.xml"), Target = "lib/net45" },
        };

        NuGetPack(nuspec, settings);
    });

Task("Finalize")
    .IsDependentOn("NuGetPack")
    .Does(() =>
    {
        DeleteDirectory(workingDir, true);
    });

RunTarget(target);
