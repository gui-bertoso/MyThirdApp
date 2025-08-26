using System.Text.Json;

namespace MyThirdApp;

public class MyThirdApp
{
    class Task
    {
        private string name = "TaskName";
        private string description = "Task";
    }

    static void Main(string[] args)
    {
        List<string> tasks = new List<string>();
        if (File.Exists("tasks_save.json"))
        {
            Console.WriteLine("The save exists!");
        }
        else
        {
            Console.WriteLine("The save does not exist!");
            Console.Write("Do you want to create a tasks save?");
            string response = Console.ReadLine();
            if (response == "y" && response == "yes" && response == "Y" && response == "Yes")
            {
                string json_file = JsonSerializer.Serialize(tasks);
                File.WriteAllText("tasks_save.json", json_file);
            }
            Console.WriteLine("Created a tasks save!");
        }
    }
}