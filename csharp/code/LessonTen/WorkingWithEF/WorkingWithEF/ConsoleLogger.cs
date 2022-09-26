using Microsoft.Extensions.Logging;

namespace Shared;

public class ConsoleLoggerProvider : ILoggerProvider
{
    public void Dispose() { }

    public ILogger CreateLogger(string categoryName)
    {
        return new ConsoleLogger();
    }
}

public class ConsoleLogger : ILogger
{
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        if (eventId.Id == 20100)
        {
            Console.Write($"Level: {logLevel}, Event Id: {eventId}");
            if (state is not null)
            {
                Console.Write($", State {state}");
            }

            if (exception is not null)
            {
                Console.Write($", Exception: {exception.Message}");
            }

            Console.WriteLine();
        }
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        switch (logLevel)
        {
            case LogLevel.Trace:
            case LogLevel.Information:
            case LogLevel.None:
                return false;
            case LogLevel.Debug:
            case LogLevel.Warning:
            case LogLevel.Error:
            case LogLevel.Critical:
            default:
                return true;
        }
    }

    public IDisposable BeginScope<TState>(TState state)
    {
        return null;
    }
}