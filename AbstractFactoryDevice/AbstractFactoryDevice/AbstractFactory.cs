using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractDevice CreateDevice();
        public abstract AbstractCharger CreateCharger();
    }
}
