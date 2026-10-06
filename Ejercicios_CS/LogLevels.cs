using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Substring(logLine.IndexOf(':') + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int end = logLine.IndexOf(']');
        return logLine.Substring(1, end - 1).ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}

class LogLineProgram
{
    static void Main(string[] args)
    {
        string[] logs = {
            "[ERROR]: Invalid operation",
            "[WARNING]:  Disk space low   \t\r\n",
            "[INFO]: Timezone changed"
        };

        foreach (string log in logs)
        {
            Console.WriteLine($"Log original: \"{log.Trim()}\"");
            Console.WriteLine($"Mensaje     : \"{LogLine.Message(log)}\"");
            Console.WriteLine($"Nivel       : \"{LogLine.LogLevel(log)}\"");
            Console.WriteLine($"Reformateado: \"{LogLine.Reformat(log)}\"");
            Console.WriteLine(new string('-', 45));
        }
    }
}