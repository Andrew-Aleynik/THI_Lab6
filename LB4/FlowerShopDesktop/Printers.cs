using System;

namespace LB4
{
    namespace Printers
    {
        interface IObjectPrinter
        {
            void Print(Object obj);
        }

        class ConsoleObjectPrinter : IObjectPrinter
        {
            public void Print(Object obj)
            {
                Console.WriteLine(obj?.ToString());
            }
        }
    }
}