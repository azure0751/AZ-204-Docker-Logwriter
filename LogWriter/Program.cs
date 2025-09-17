
    string logDirectory = Path.Combine(AppContext.BaseDirectory, "logs");
    Directory.CreateDirectory(logDirectory);

    string logFile = Path.Combine(logDirectory, "app.log");

    Console.WriteLine($"Logging to: {logFile}");
    Console.WriteLine("Press Ctrl+C to stop.");

    int counter = 0;
    while (true)
    {
        string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Log entry #{counter}";
        File.AppendAllText(logFile, logMessage + Environment.NewLine);

        Console.WriteLine(logMessage);
        counter++;

        Thread.Sleep(5000); // log every 5 seconds
    }
