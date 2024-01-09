using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFabric
{
    // Конкретные продукты создаются соответствующими Конкретными Фабриками.
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
}
