using System.Net;

public class TaskManagerList{
    public static void Main(){

        List<string> tasks = new List<string>();
        List<string> status = new List<string>();

        TaskManager program = new TaskManager();
        Console.WriteLine("\nChoose option - (1)=Add Task, (2)=Mark Complete, (3)=Display Tasks, (4)=Quit: ");
        string option = Console.ReadLine(); 
        while(option != "4"){
            if(option == "1")
                program.AddTask(tasks,status);
            else if(option == "2")
                program.MarkComplete(tasks,status);
            else if(option == "3")
                program.DisplayTasks(tasks,status);
            else
                Console.WriteLine("Please choose correct Option:");

            Console.WriteLine("\nChoose option - (1)=Add Task, (2)=Mark Complete, (3)=Display Tasks, (4)=Quit: ");
            option = Console.ReadLine(); 
        }
        program.Quit();
    }

    public void AddTask(List<string> tasks, List<string> status){
        Console.WriteLine("Enter Task to be added");
        string newTask = Console.ReadLine(); 
        if(!string.IsNullOrEmpty(newTask)){
            if(tasks.Count < 3){
                tasks.Add(newTask);
                status.Add("Incomplete");
                Console.WriteLine("Task "+ newTask +" added successfully.");
                return;
            }
            else{
                Console.WriteLine("Task List already full");
                return;
            }
        }else{
            Console.WriteLine("Cannot add Empty Task");
            return;
        }
    }

    public void MarkComplete(List<string> tasks, List<string> status){
        Console.WriteLine("Enter task number to mark as Completed");
        foreach(string task in tasks){
            int index = tasks.IndexOf(task) + 1;
            Console.WriteLine(index + " --> " + task);
        }

        string input = Console.ReadLine();
        if(int.Parse(input)<=tasks.Count){
            int index = int.Parse(input) - 1;
            status[index] = "Complete";
            Console.WriteLine("Task " + tasks[index] + " marked as Completed");
        }    
        else {
            Console.WriteLine("Enter Valid Task Number");
        }
    }

    public void DisplayTasks(List<string> tasks, List<string> status){
        Console.WriteLine("Tasks:");
        for(int i=0;i<tasks.Count;i++){
            int j=i+1;
            Console.WriteLine("Task " + j + ": "+ tasks[i] + " || Status : " + status[i]);
        }
    }

    public void Quit(){
        Console.WriteLine("Thankyou!");
    }

}