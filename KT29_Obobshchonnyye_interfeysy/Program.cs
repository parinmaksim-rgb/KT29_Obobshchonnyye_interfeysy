using System;

namespace KT29_Obobshchonnyye_interfeysy
{
    public interface IContainer<out T>
    {
        T GetItem();
    }
    public class Animal
    {
        public string Name { get; set; } = "животное";
        public virtual void Speak() => Console.WriteLine($"{Name} издает звук.");
    }

    public class Dog : Animal
    {
        public Dog()
        {
            Name = "Собака";

        }
        public Dog(string name)
        {
            name = name;
        }

        public override void Speak() => Console.WriteLine($"{Name} говорит: Гав-гав!");
    }

    public class Box<T> : IContainer<T>
    {
        private readonly T _item;
        public Box(T item)
        {
            _item = item;
        }
        public T GetItem()
        {
            return _item;
        }
    }
    public class Program
    {
        public static void Main()
        {
            IContainer<Animal> c = new Box<Dog>(new Dog());
            Animal retrievedAnimal = c.GetItem();
            Console.WriteLine($"Успешно получен объект типа: {retrievedAnimal.GetType().Name}");
            retrievedAnimal.Speak();
            //Box<Animal> b = new Box<Dog>(new Dog());

        }
    }
}
