using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTV = new TV(false, "Samsung");
            // method comes from parent class
            myTV.SwitchOn();
            //method comes from child class
            myTV.WatchTV();
        }
    }
}
