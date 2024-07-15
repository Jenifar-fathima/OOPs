namespace OOPs.OOPS_Concept.Day___06.PolyMorphism
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound");
        }

        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }

        public new void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
    }

    public class Labrador : Dog
    {
        public sealed override void MakeSound()
        {
            Console.WriteLine("Labrador barks loudly");
        }
        public void Play()
        {
            Console.WriteLine("Labrador is playing fetch");
        }
    }

    class MainPolymorphism
    {
        public static void Solution()
        {
            Animal animal = new Animal();
            animal.MakeSound();  
            animal.Eat();        
            Console.WriteLine();

            Dog dog = new Dog();
            dog.MakeSound();     
            dog.Eat();           
            Console.WriteLine();

            Labrador labrador = new Labrador();
            labrador.MakeSound(); 
            labrador.Eat();
            labrador.Play();      
            Console.WriteLine();
        }
    }
}