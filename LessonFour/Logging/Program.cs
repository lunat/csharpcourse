using System.Diagnostics;
using static System.Console;
using Microsoft.Extensions.Configuration;

Trace.Listeners.Add(new TextWriterTraceListener(
    File.CreateText(Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.DesktopDirectory), "log.txt"))));

Trace.AutoFlush = true;

ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json",
        optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();
TraceSwitch ts = new(
    displayName: "LogSwitch",
    description: "This switch is set via a JSON config.");

configuration.GetSection("LogSwitch").Bind(ts);

Trace.WriteLineIf(ts.TraceError, "Trace Error");
Trace.WriteLineIf(ts.TraceWarning, "Trace Warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace Info");
Trace.WriteLineIf(ts.TraceVerbose, "Trace Verbose");


//
//Debug.WriteLine("Debug says I am watching");
//Trace.WriteLine("Trace says I am watching");