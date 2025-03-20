// class ToDoList{
//     public string[] tasks = new string[10];
//     public int taskCount = 0;

//     void AddTask(){
//         string task = Console.ReadLine();
//         tasks[taskCount] = task;
//         taskCount++;
//     }

//     void ViewTask(){
//         for(int i = 0; i < taskCount; i++){
//             Console.WriteLine(tasks[i]);
//         }
//     }

//     void CompleteTask(){
//         Console.WriteLine("Which task do you want to complete?");
//         for(int i = 0; i < taskCount; i++){
//             Console.WriteLine(i + ". " + tasks[i]);
//         }
//         int input = int.Parse(Console.ReadLine());

//         if(input >= taskCount || input < 0){
//             Console.WriteLine("Invalid task number");
//             return;
//         }

//         tasks[input] = tasks[input] + " (completed)";
//     }

//     public static void Main(string[] args){
//         bool running = true;
//         ToDoList list = new ToDoList();
//         while(running){
//             Console.WriteLine("1. Add task");
//             Console.WriteLine("2. View tasks");
//             Console.WriteLine("3. Complete task");
//             Console.WriteLine("4. Exit");
//             int input = int.Parse(Console.ReadLine());
//             switch(input){
//                 case 1:
//                     list.AddTask();
//                     break;
//                 case 2:
//                     list.ViewTask();
//                     break;
//                 case 3:
//                     list.CompleteTask();
//                     break;
//                 case 4:
//                     running = false;
//                     break;
//             }
//         }
//     }
// }