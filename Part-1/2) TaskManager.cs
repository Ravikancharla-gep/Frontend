// public class TaskManager{

//     public string task1 = "";
//     public string task2 = "";
//     public string task3 = "";
//     public bool task1_status = false;
//     public bool task2_status = false;
//     public bool task3_status = false;

//     public static void Main(){
//         TaskManager program = new TaskManager();
//         program.DisplayMenu();
//     }
    
//     public void DisplayMenu(){
//         Console.WriteLine("\nChoose option - (1)=Add Task, (2)=Mark Complete, (3)=Display Tasks, (4)=Quit: ");
//         string option = Console.ReadLine(); 
//         switch (option){
//             case "1":
//                 AddTask();
//                 break;
//             case "2":
//                 MarkComplete();
//                 break;
//             case "3":
//                 DisplayTasks();
//                 break;
//             case "4":
//                 Quit();
//                 break;
//             default:
//                 Console.WriteLine("Please choose correct Option:");
//                 DisplayMenu();
//                 return;
//         }
//     }

//     public void AddTask(){
//         Console.WriteLine("Enter Task to be added");
//         string task = Console.ReadLine(); 
//         if(task1=="")
//             task1 = task;
//         else if(task2=="")
//             task2 = task;
//         else if(task3=="")
//             task3 = task;
//         else{
//             Console.WriteLine("Task List already full");
//             DisplayMenu();
//             return;
//         }
//         Console.WriteLine("Task "+ task +" added successfully.");
//         DisplayMenu();
//     }

//     public void MarkComplete(){
//         Console.WriteLine("Enter task number to mark (1,2,3)");
//         string input = Console.ReadLine();
//         if(input == "1" && task1!=""){
//             task1_status = true;
//             Console.WriteLine(task1 + " is marked as true");
//         }
//         else if(input == "2" && task2!=""){
//             task2_status = true;
//             Console.WriteLine(task2 + " is marked as true");
//         }
//         else if(input == "3" && task3!=""){
//             task3_status = true;
//             Console.WriteLine(task3 + " is marked as true");
//         }
//         else {
//             Console.WriteLine("Enter Valid Task");
//         }

//         DisplayMenu();
//     }

//     public void DisplayTasks(){
//         if(task1!="")
//             Console.WriteLine("Task 1: "+ task1 + " || Status " + task1_status);
//         if(task2!="")
//             Console.WriteLine("Task 2: "+ task2 + " || Status " + task2_status);
//         if(task3!="")
//             Console.WriteLine("Task 3: "+ task3 + " || Status " + task3_status);
//         DisplayMenu();
//     }

//     public void Quit(){
//         Console.WriteLine("Thankyou!");
//     }

// }