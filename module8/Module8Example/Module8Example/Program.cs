using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.A class can implement any number of interfaces but a subclass can at most use only one abstract class.
//2.An abstract class can have non-abstract Methods(concrete methods) while in case of Interface all the methods has to be abstract.
//3.An abstract class can declare or use any variables while an interface is not allowed to do so.
//4.An abstract class can have constructor declaration while an interface can not do so.
//5.An abstract Class is allowed to have all access modifiers for all of its member declaration while in interface we cannot declare any access modifier (including public) as all the members of interface are implicitly public.  

namespace Module8Example
{
    class Program : MyAbstractClass, MyInterface
    {
        static void Main(string[] args)
        {

        }

        public override void getAbsName()
        {
            Console.WriteLine("A class name from abstract");
        }

        void MyInterface.getMethod()
        {
            Console.WriteLine("A method from interface");
        }

        string MyInterface.getName()
        {
            return string.Format("A name from interface");
        }
    }


    interface MyInterface
    {
        void getMethod();
        string getName();
    }
    abstract class MyAbstractClass
    {
        public abstract void getAbsName();
        public void greetingFromAbstract()
        {
            Console.WriteLine("Greetings from Abstract Class");
        }
    }
}
