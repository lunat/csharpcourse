using System.Diagnostics;
using static System.Diagnostics.Process;
using static System.Console;
using System.Dynamic;

namespace MonitoringLib;
public static class Recorder
{
    private static Stopwatch _timer = new();
    private static long _bytesPhysicalBefore = 0;
    private static long _byteVirtualBefore = 0;

    public static void Start()
    {
        // force two garbage collections to release memory that is
        // no longer referenced but has not been released yet
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        // store the current physical and virtual memory in use
        _bytesPhysicalBefore = GetCurrentProcess().WorkingSet64;
        _byteVirtualBefore = GetCurrentProcess().VirtualMemorySize64;
        _timer.Restart();
    }

    public static void Stop()
    {
        _timer.Stop();
        long bytesPhysicalAfter = GetCurrentProcess().WorkingSet64;
        long bytesVirtualAfter = GetCurrentProcess().VirtualMemorySize64;

        WriteLine("{0:N0} physical bytes used."
            , bytesPhysicalAfter - _bytesPhysicalBefore);

        WriteLine("{0:N0} virtual bytes used."
            , bytesVirtualAfter - _byteVirtualBefore);

        WriteLine("{0} timespan elapsed", _timer.Elapsed);
        WriteLine("{0:N0} timespan elapsed milliseconds", _timer.ElapsedMilliseconds);

    }
}
