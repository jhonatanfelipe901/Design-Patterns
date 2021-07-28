using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ConcreteClass.Charger
{
    public class ChargerS1 : AbstractCharger
    { 
        public ChargerS1()
        {
        }

        public ChargerS1(string name, int size)
        {
            this.Name = name;
            this.Size = size;
        }
    }
}
