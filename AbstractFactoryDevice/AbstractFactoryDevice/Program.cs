using AbstractFactory;
using AbstractFactory.Factory;
using System;

namespace AbstractFactoryDevice
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;
            client = new Client(new NotebookFactory());
            client.Run();
            client = new Client(new CellphoneFactory());
            client.Run();
        }
    }
}
