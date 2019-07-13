﻿namespace Command
{
    public class Light
    {
        public bool IsOn { get; private set; }

        public void On()
        {
            this.IsOn = true;
        }

        public void Off()
        {
            this.IsOn = false;
        }
    }
}
