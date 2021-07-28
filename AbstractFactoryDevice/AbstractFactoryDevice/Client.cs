using AbstractFactory.Abstract;
using System;

namespace AbstractFactory
{
    public class Client
    {
        private AbstractCharger charger;
        private AbstractDevice device;

        public Client(AbstractFactory factory)
        {
            charger = factory.CreateCharger();
            device = factory.CreateDevice();
        }

        public void Run()
        {
            device.Interact(charger);
        }
    }
}
