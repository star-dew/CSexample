using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //MyClass.StaticMethod();

            //MyClass myClass = new MyClass();
            //myClass.InstanceMethod();

            //
            //Console.WriteLine("Shallow Copy");
            //{
            //    MyClass source = new MyClass();
            //    source.MyField1 = 10;
            //    source.MyField2 = 20;

            //    MyClass target = source;
            //    target.MyField2 = 30;

            //    Console.WriteLine($"{source.MyField1} {source.MyField2}");
            //    Console.WriteLine($"{target.MyField1} {target.MyField2}");
            //}


            //Console.WriteLine("Deep Copy");
            //{ 
            //    DeepCopyClass source = new DeepCopyClass();
            //    source.MyField1 = 10;
            //    source.MyField2 = 20;

            //    DeepCopyClass target = new DeepCopyClass();
            //    target.MyField2 = 30;

            //    Console.WriteLine($"{source.MyField1} {source.MyField2}");
            //    Console.WriteLine($"{target.MyField1} {target.MyField2}");
            //}

            //
            //Console.WriteLine("#####Test3#####");
            //{
            //    Employee pooh = new Employee();
            //    pooh.SetName("Pooh");
            //    pooh.SetPosition("Waiter");
            //    Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

            //    Employee tiger = new Employee();
            //    tiger.SetName("Tiger");
            //    tiger.SetPosition("Cleaner");
            //    Console.WriteLine($"{tiger.GetName()} {tiger.GetPosition()}");
            //}

            //
            //Console.WriteLine("#####Test4#####");
            //{
            //    ThisClass a = new ThisClass();
            //    a.PringFields();

            //    ThisClass b = new ThisClass(1);
            //    b.PringFields();

            //    ThisClass c = new ThisClass(10, 20);
            //    c.PringFields();

            //}

            //
            Console.WriteLine("#####Test5#####");
            {
                try
                {
                    WaterHeater heater = new WaterHeater();
                    heater.SetTemperature(20);
                    heater.TurnOnWater();

                    heater.SetTemperature(-2);
                    heater.TurnOnWater();

                    heater.SetTemperature(50);
                    heater.TurnOnWater();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
