LocalFileLogger<string> localFileLogger_string = new("test.txt");
localFileLogger_string.LogInfo("Hi, I am Fanis!!!!");
localFileLogger_string.LogError("Bars grup!!!!", new Exception("It is Exception"));
localFileLogger_string.LogWarning("C#");

LocalFileLogger<int> localFileLogger_int = new("test.txt");
localFileLogger_int.LogInfo("Hi, I am Fanis!!!!");
localFileLogger_int.LogError("Bars grup!!!!", new Exception("It is Exception"));
localFileLogger_int.LogWarning("C#");

LocalFileLogger<double> localFileLogger_double = new("test.txt");
localFileLogger_double.LogInfo("Hi, I am Fanis!!!!");
localFileLogger_double.LogError("Bars grup!!!!", new Exception("It is Exception"));
localFileLogger_double.LogWarning("C#");

LocalFileLogger<bool> localFileLogger_bool = new("test.txt");
localFileLogger_bool.LogInfo("Hi, I am Fanis!!!!");
localFileLogger_bool.LogError("Bars grup!!!!", new Exception("It is Exception"));
localFileLogger_bool.LogWarning("C#");