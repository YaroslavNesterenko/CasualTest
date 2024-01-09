using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFabric
{
    // Каждый отдельный продукт семейства продуктов должен иметь базовый
    // интерфейс. Все вариации продукта должны реализовывать этот интерфейс.
    public interface IAbstractProductA
    {
        string UsefulFunctionA();
    }
}
