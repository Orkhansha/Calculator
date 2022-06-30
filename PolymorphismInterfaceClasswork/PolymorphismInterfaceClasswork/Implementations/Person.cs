using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismInterfaceClasswork
{
    public class Person : Test, ISpeak, IEating
    {
        public void Eating(DateTime time)
        {
            Console.WriteLine("Person eating -"+DateTime.Now); ;
        }

        public void Speak()
        {
            Console.WriteLine("Person speake");
        }
    }
    public interface ISpeak
    {
        void Speak();
    }
    public interface IEating
    {
        void Eating(DateTime time);
    }
}
