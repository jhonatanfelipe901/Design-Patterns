using AbstractFactory.Abstract;
using AbstractFactory.ConcreteClass.Charger;
using AbstractFactory.ConcreteClass.Device;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    public class CellphoneFactory : AbstractFactory
    {
        public override AbstractCharger CreateCharger()
        {
            //Mock
            ChargerS2 chargers2 = new ChargerS2("Carregador fera", 15);

            return chargers2;
        }

        public override AbstractDevice CreateDevice()
        {
            //Mock
            Cellphone notebook = new Cellphone("Iphone 8", "128GB", "Camera fera");

            return notebook;
        }
    }
}
