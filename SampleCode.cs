using System;

public class SampleCode
{
	static void Main() 
	{
		Task task = new Task(CallMethod);
		task.Start();
		task.Wait();
		Console.ReadLine();
	}

	static async void CallMethod() 
	{
		string filePath = @"C:\\Users\Bla\sampleFile.txt";
		Task<int> ReadFile(filePath);

		global::System.Console.WriteLine("Other Work1");
		global::System.Console.WriteLine("Other Work2");
		global::System.Console.WriteLine("Other Work3");

		int length =  await task;
		global::System.Console.WriteLine("Total lenght: " + length);

		global::System.Console.WriteLine(" After work 1");
		global::System.Console.WriteLine(" After work 2");
	}

	static async Task<int> ReadFile(string file) 
	{
		int length = 0;

        global::System.Console.WriteLine("File Reading is starting");

        using

        {
            // reads all chars from the curr positon to the end of the file stream and returns them as one string

            length = string.length;
        }

        global::System.Console.WriteLine("File reading is completed");
        return length;
    }
}
