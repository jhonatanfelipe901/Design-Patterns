using AbstractFactory.Abstract;
using AbstractFactory.ConcreteClass.Charger;
using AbstractFactory.ConcreteClass.Device;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    public class NotebookFactory : AbstractFactory
    {
        public override AbstractCharger CreateCharger()
        {
            //Mock
            ChargerS1 chargers1 = new ChargerS1("Carregador legal", 25);

            return chargers1;
        }

        public override AbstractDevice CreateDevice()
        {
            //Mock
            Notebook notebook = new Notebook("Samsung V1", "128GB", "WebCamTOP");

            return notebook;
        }
    }
}
