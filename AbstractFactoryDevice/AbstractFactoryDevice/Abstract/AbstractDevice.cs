using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Abstract
{
    public abstract class AbstractDevice
    {
        public string Model { get; set; }
        public string Memory { get; set; }

        public abstract void Interact(AbstractCharger charger);
    }
}
