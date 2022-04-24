using System;
namespace InheritanceDemo
{
    //CHILD CLASS

    //Calling Parent class onto the child class
    public class Radio : ElectricalDevice
    {
        // Simple Constructor

        //Since the properties are coming from a base class and the base class contains a constructor, we can use a "base" keyword to pass to our base class its constructor arguments.
        //Because these are the only two properties we have and our constructor in the child class will have an empty body

        public Radio(bool isOn, string brand) : base(isOn, brand) {}

        //Methods for the functionality of the radio
 
        //Listen to the radio

        public void ListenRadio()
        {
            if (IsOn)
            {
                //Listen to the radio
                Console.WriteLine("Listening to the Radio");
            }
            else
            {
                //Error Message
                Console.WriteLine("Radio is off, switch it on first");
            }      
        }
    }
}
