
// public interface IAnimal{
//     void Eat();
// }
// public class OOPS{
//     public static void Main(string[] args){
//         Dog dog = new Dog();
//         Cat cat = new Cat();

//         // Simple Way

//         // dog.MakeSound();
//         // dog.Eat();
//         // cat.MakeSound();
//         // cat.Eat();

//         //-------OR-----------

//         // Animal[] animals = new Animal[2];
//         // animals[0] = new Dog();
//         // animals[1] = new Cat();

//         //--------OR------------------------

//         // List<Animal> animals = new List<Animal>();
//         // animals.Add(new Dog());
//         // animals.Add(new Cat());

//         // -------OR-----------

//         List<Animal> animals = new List<Animal>(){
//             new Dog(),
//             new Cat()
//         };

//         foreach(Animal animal in animals){
//             animal.MakeSound();
//             animal.Eat();
//         }
//     }
// }

// public class Animal: IAnimal{
//     public virtual void MakeSound(){
//         Console.WriteLine("Animal sound");
//     }
//     public void Eat(){
//         Console.WriteLine("Animal is eating");
//     }
// }

// public class Dog : Animal{
//     public override void MakeSound(){
//         Console.WriteLine("Bark!");
//     }
// }

// public class Cat : Animal{
//     public override void MakeSound(){
//         Console.WriteLine("Meow!");
//     }
//     // We use new keyword to hide the base class method
//     public new void Eat(){
//         Console.WriteLine("Cat is eating");
//     }
// }