using System;

public class Animals
{
    public virtual void EatFood()
    {
        Console.WriteLine("Zwierzę je jedzenie.");
    }

    public virtual void Move()
    {
        Console.WriteLine("Zwierzę porusza się.");
    }
}

public class Mammal : Animals
{
    public override void EatFood()
    {
        Console.WriteLine("Ssak je jedzenie.");
    }

    public override void Move()
    {
        Console.WriteLine("Ssak porusza się.");
    }
}

public class Bird : Animals
{
    public override void EatFood()
    {
        Console.WriteLine("Ptak je jedzenie.");
    }

    public override void Move()
    {
        Console.WriteLine("Ptak porusza się.");
    }
}

public class Cat : Mammal
{
    public override void EatFood()
    {
        Console.WriteLine("Kot je karmę dla kotów.");
    }

    public override void Move()
    {
        Console.WriteLine("Kot porusza się skacząc.");
    }
}

public class Dog : Mammal
{
    public override void EatFood()
    {
        Console.WriteLine("Pies je karmę dla psów.");
    }

    public override void Move()
    {
        Console.WriteLine("Pies porusza się biegnąc.");
    }
}

public class Eagle : Bird
{
    public override void EatFood()
    {
        Console.WriteLine("Orzeł je mięso.");
    }

    public override void Move()
    {
        Console.WriteLine("Orzeł porusza się latając.");
    }
}

public class Penguin : Bird
{
    public override void EatFood()
    {
        Console.WriteLine("Pingwin je ryby.");
    }

    public override void Move()
    {
        Console.WriteLine("Pingwin porusza się chodząc.");
    }
}

public class AnimalActions
{
    public void DoActions(Animals animal)
    {
        animal.EatFood();
        animal.Move();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        AnimalActions animalActions = new AnimalActions();
        Mammal mammal = new Mammal();
        Bird bird = new Bird();

        Animals animal1 = new Cat();
        Animals animal2 = new Dog();
        Animals animal3 = new Eagle();
        Animals animal4 = new Penguin();

        mammal.EatFood();
        animalActions.DoActions(animal1);
        Console.WriteLine();

        mammal.EatFood();
        animalActions.DoActions(animal2);
        Console.WriteLine();

        bird.EatFood();
        animalActions.DoActions(animal3);
        Console.WriteLine();

        bird.EatFood();
        animalActions.DoActions(animal4);
    }
}
