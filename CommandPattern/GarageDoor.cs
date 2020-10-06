using System;

namespace CommandPattern
{
    public class GarageDoor
    {
        public void up()
        {
            Console.WriteLine("Garage door is open.");
        }
        public void down()
        {
            Console.WriteLine("Garage door is closed.");
        }
        public void stop()
        {
            Console.WriteLine("Garage door has stopped.");
        }
        public void lightOn()
        {
            Console.WriteLine("Garage light is on.");
        }
        public void lightOff()
        {
            Console.WriteLine("Garage light is off.");
        }
    }
}
