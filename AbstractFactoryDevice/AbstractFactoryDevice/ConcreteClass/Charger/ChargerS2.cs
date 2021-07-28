using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ConcreteClass.Charger
{
    public class ChargerS2 : AbstractCharger
    {
        public ChargerS2()
        {
        }

        public ChargerS2(string name, int size)
        {
            this.Name = name;
            this.Size = size;
        }
    }
}
