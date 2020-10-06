﻿namespace CommandPattern
{
    public class LightOnCommand : Command
    {
        private Light _light;
        public LightOnCommand(Light light)
        {
            _light = light;
        }
        public void execute()
        {
            _light.on();
        }
    }
}
