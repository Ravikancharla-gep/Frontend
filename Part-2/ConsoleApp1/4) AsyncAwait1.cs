// public class Program
// {
//     public async Task Download1(){
//         Console.WriteLine("Download1 started");
//         await Task.Delay(3000);
//         Console.WriteLine("Download1 completed");
//     }

//     public async Task Download2(){
//         Console.WriteLine("Download2 started");
//         await Task.Delay(5000);
//         Console.WriteLine("Download2 completed");
//     }

//     public static async Task Main(string[] args)
//     {
//         Program p = new Program();
//         p.Download1();
//         await p.Download2();

//         // Task.WhenAll(p.Download1(), p.Download2());

//         await Task.Delay(1000);
//         Console.WriteLine("All downloads completed");
//     }
// }

