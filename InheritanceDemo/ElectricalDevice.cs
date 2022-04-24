using System;
namespace InheritanceDemo
{
    //PARENT CLASS - BASE

    public class ElectricalDevice
    {
        //boolean to determine the state of the ElectricalDevice
        public bool IsOn { get; set; }
        //string for the brand name of the ElectricalDevice
        public string Brand { get; set; }

        //Simple Constructor
        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        // Methods for ElectricalDevice functionalities

        public void SwitchOn()
        {
            IsOn = true;
        }

        //Switch off the TV
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
