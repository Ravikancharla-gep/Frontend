// using System.Net;
// public class InventoryManagement{
//     private void ViewProducts(List<int> productId, List<string> productName, List<string> productPrice, List<string> productQty)
//     {
//         Console.WriteLine("Product List:");
//         if(productId.Count == 0){
//             Console.WriteLine("No Products Available!");
//             Console.WriteLine("------------------------------------------------------------\n");
//             return;
//         }
//         for(int i=0;i<productId.Count;i++){
//             Console.WriteLine("Product ID: " + productId[i] + " || Product Name: " + productName[i] + " || Product Price: " + productPrice[i] + " || Product Quantity: " + productQty[i]);
//         }
//         Console.WriteLine("------------------------------------------------------------\n");
//     }

//     private void AddProduct(List<int> productId, List<string> productName, List<string> productPrice, List<string> productQty)
//     {
//         Console.WriteLine("Enter Product ID: ");
//         int id = int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter Product Name: ");
//         string name = Console.ReadLine();
//         Console.WriteLine("Enter Product Price: ");
//         string price = Console.ReadLine();
//         Console.WriteLine("Enter Product Quantity: ");
//         string qty = Console.ReadLine();

//         productId.Add(id);
//         productName.Add(name);
//         productPrice.Add(price);
//         productQty.Add(qty);
        
//         Console.WriteLine("Product Added Successfully");
//         Console.WriteLine("------------------------------------------------------------\n");

//     }

//     private void RemoveProduct(List<int> productId, List<string> productName, List<string> productPrice, List<string> productQty)
//     {   
//         Console.WriteLine("Enter Product ID to be removed: ");
//         int id = int.Parse(Console.ReadLine());

//         int index = productId.IndexOf(id);
//         productName.RemoveAt(index);
//         productPrice.RemoveAt(index);
//         productQty.RemoveAt(index);

//         Console.WriteLine("Product Removed Successfully");
//         Console.WriteLine("------------------------------------------------------------\n");
//     }

//     private void UpdateStock(List<int> productId, List<string> productQty)
//     {
//         Console.WriteLine("Enter the Product ID to update stock:");
//         int id = int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the new Quantity:");
//         string qty = Console.ReadLine();

//         int index = productId.IndexOf(id);
//         productQty[index] = qty;

//         Console.WriteLine("Stock Updated Successfully");
//         Console.WriteLine("------------------------------------------------------------\n");
//     }

//     private void UpdatePrice(List<int> productId, List<string> productPrice)
//     {
//         Console.WriteLine("Enter the Product ID to update stock:");
//         int id = int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter the new Price:");
//         string price = Console.ReadLine();

//         int index = productId.IndexOf(id);
//         productPrice[index] = price;

//         Console.WriteLine("Stock Updated Successfully");
//         Console.WriteLine("------------------------------------------------------------\n");
//     }
    
//     public void Quit(){
//         Console.WriteLine("Thankyou! Have a nice Day");
//         Console.WriteLine("------------------------------------------------------------\n");
//     }

//     public static void Main(){

//         List<int> productId = new List<int>();
//         List<string> productName = new List<string>();
//         List<string> productPrice = new List<string>();
//         List<string> productQty = new List<string>();
//         InventoryManagement inventory = new InventoryManagement();

//         Console.WriteLine("\n------------------------------------------------------------");
//         Console.WriteLine("\nWelcome to Inventory Management System. Choose:");
//         Console.WriteLine(" (1) = View Products\n (2) = Add Product\n (3) = Remove Product\n (4) = Update Stock\n (5) = Update Price\n (0) = Quit: ");
        
//         string option = Console.ReadLine(); 
//         while(option != "0"){
//             if(option == "1")
//                 inventory.ViewProducts(productId,productName,productPrice,productQty);
//             else if(option == "2")
//                 inventory.AddProduct(productId,productName,productPrice,productQty);
//             else if(option == "3")
//                 inventory.RemoveProduct(productId,productName,productPrice,productQty);
//             else if(option == "4")
//                 inventory.UpdateStock(productId,productQty);
//             else if(option == "5")
//                 inventory.UpdatePrice(productId,productPrice);
//             else{
//                 Console.WriteLine("Please choose correct Option:");
//                 return;
//             }

//             Console.WriteLine(" (1) = View Products\n (2) = Add Product\n (3) = Remove Product\n (4) = Update Stock\n (5) = Update Price\n (0) = Quit: ");
//             option = Console.ReadLine();
//         }
//         inventory.Quit();
//     }

// }