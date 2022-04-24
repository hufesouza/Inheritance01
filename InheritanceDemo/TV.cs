using System;
namespace InheritanceDemo
{
    //Calling parent class onto the child class
    public class TV : ElectricalDevice
    {
        //Simple Constructor
        //Since the properties are coming from a base class and the base class contains a constructor, we can use a "base" keyword to pass to our base class its constructor arguments.
        //Because these are the only two properties we have and our constructor in the child class will have an empty body

        public TV(bool isOn, string brand) : base(isOn, brand) {}

        //Watch TV - methods for the TV functionality

        public void WatchTV()
        {
            if(IsOn)
            {
                //Watch TV
                Console.WriteLine("Watching TV!");
            }
            else
            {
                //error message
                Console.WriteLine("Tv is switched of, switch it on first!");
            }
        }
    }
}
