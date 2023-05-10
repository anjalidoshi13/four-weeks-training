abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public abstract void MakeSound();
}
class Dog : Animal, IMovable
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof");
    }
    public void Move()
    {
        Console.WriteLine("Dog is running");
    }
}
class Cat : Animal, IMovable
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
    public void Move()
    {
        Console.WriteLine("Cat is walking");
    }
}
interface IMovable
{
    void Move();
}
class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        Dog dog = new Dog { Name = "kutta", Age = 3 };
        Cat cat = new Cat { Name = "billi", Age = 2 };
        animals.Add(dog);
        animals.Add(cat);
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            if (animal is IMovable movable)
            {
                movable.Move();
            }
        }
    }
