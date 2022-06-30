using System;

namespace PolymorphismInterfaceClasswork
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Sound();
            dog.Eat();

            Bird bird = new Bird();
            bird.Sound();
            bird.Eat();

            Test test = new Test();
            test.Id = 5;

            Person person = new Person();
            person.Speak();
        }
    }
}
