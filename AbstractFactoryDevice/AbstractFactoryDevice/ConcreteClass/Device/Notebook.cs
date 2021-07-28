using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ConcreteClass.Device
{
    public class Notebook : AbstractDevice
    {
        public string WebCamModel { get; set; }

        public Notebook()
        {
        }

        public Notebook(string model, string memory, string webCamModel)
        {
            this.Model = model;
            this.Memory = memory;
            this.WebCamModel = webCamModel;
        }

        public override void Interact(AbstractCharger charger)
        {
            Console.WriteLine(this + "My Charger is: " + charger.Name);
            Console.WriteLine(this + "My Model is: " + this.Model);
            Console.WriteLine(this + "My Memory is: " + this.Memory);
            Console.WriteLine(this + "My WebCam Model is: " + this.WebCamModel);
        }
    }
}
