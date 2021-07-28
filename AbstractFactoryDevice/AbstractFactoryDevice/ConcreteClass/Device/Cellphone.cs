using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ConcreteClass.Device
{
    public class Cellphone : AbstractDevice
    {
        public string FrontalCameraModel { get; set; }

        public Cellphone()
        {
        }

        public Cellphone(string model, string memory, string frontalCameraModel)
        {
            this.Model = model;
            this.Memory = memory;
            this.FrontalCameraModel = frontalCameraModel;
        }

        public override void Interact(AbstractCharger charger)
        {
            Console.WriteLine(this + "My Charger is: " + charger.Name);
            Console.WriteLine(this + "My Model is: " + this.Model);
            Console.WriteLine(this + "My Memory is: " + this.Memory);
            Console.WriteLine(this + "My Frontal Camera is: " + this.FrontalCameraModel);
        }
    }
}
