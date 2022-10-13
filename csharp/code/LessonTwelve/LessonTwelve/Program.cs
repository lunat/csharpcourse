﻿using MonitoringLib;
using static System.Console;

WriteLine("Processing, wait..");
/*
Recorder.Start();

//simulate a long running process
int[] largeArrayOfInts = Enumerable.Range(start: 1, count: 10_000).ToArray();

Thread.Sleep(new Random().Next(5,10) * 1000);

Recorder.Stop();
*/

int[] numbers = Enumerable.Range(1, 50_000).ToArray();
WriteLine("Using string concat with +");
Recorder.Start();
string s = string.Empty;
for (int i = 0; i < numbers.Length; i++)
{
    s += numbers[i] + ", ";
}
Recorder.Stop();

WriteLine("Using StringBuilder");
Recorder.Start();
System.Text.StringBuilder builder = new();
for (int i = 0; i < numbers.Length; i++)
{
    builder.Append(numbers[i]);
    builder.Append(", ");
}
Recorder.Stop();