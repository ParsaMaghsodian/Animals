// See https://aka.ms/new-console-template for more information
using Animals;

Dog dog = new Dog();
dog.Feet = 4;
dog.NameOfAmimal = "popi";
dog.Food = "Meat and Milk";
dog.Color = "White";
dog.Sound = "Woof Woof";
dog.Move = "Walking";
Console.WriteLine(dog.Eat());
Console.WriteLine("This " + dog.NameOfAmimal + " has " + dog.NumbersOfFoot() + " feet");
Console.WriteLine(dog.Howmove());
Console.WriteLine(dog.MakeSound());
//------------------------------------------------------------------------------------------
Console.WriteLine("------------------------------------------------------------------------------");
Snake snake = new Snake();
snake.Food = "Mouse";
snake.Color = "Dark";
snake.NameOfAmimal = "Snake";
snake.Move = "Crawl across the floor";
snake.Sound = "shir shir";
Console.WriteLine(snake.Eat());
Console.WriteLine(snake.Howmove());
Console.WriteLine(snake.MakeSound());
Console.WriteLine("This " + snake.NameOfAmimal + " has " + snake.NumbersOfFoot() + " Feet");
Console.Read();