using LB4.FlowerShop;
using LB4.Loggers;
using LB4.Printers;

namespace LB4
{
    namespace Factories
    {
        interface IAbstractFlowerFactory
        {
            public Rose CreateRose(String color, int price);
            public Tulpin CreateTulpin(String color, int price);
            public Iris CreateIris(String color, int price);
            public Gladiolus CreateGladiolus(String color, int price);

        }

        class AbstractFlowerFactory : IAbstractFlowerFactory
        {
            public Gladiolus CreateGladiolus(string color, int price)
            {
                return new Gladiolus(color, price);
            }

            public Iris CreateIris(string color, int price)
            {
                return new Iris(color, price);
            }

            public Rose CreateRose(string color, int price)
            {
                return new Rose(color, price);
            }

            public Tulpin CreateTulpin(string color, int price)
            {
                return new Tulpin(color, price);
            }
        }

        interface IWrapperFactory
        {
            public Wrapper CreateWrapper(String material, int price);
        }

        class WrapperFactory : IWrapperFactory
        {
            public Wrapper CreateWrapper(string material, int price)
            {
                return new Wrapper(material, price);
            }
        }

        interface IBouquetFactory
        {
            Bouquet Create(Wrapper wrapper, AbstractFlower[] flowers);
            Bouquet Create(Wrapper wrapper);
        }

        class BouquetFactory : IBouquetFactory
        {
            public Bouquet Create(Wrapper wrapper)
            {
                return new Bouquet(wrapper);
            }
            public Bouquet Create(Wrapper wrapper, AbstractFlower[] flowers)
            {
                return new Bouquet(wrapper, flowers);
            }
        }

        interface ILoggerFactory
        {
            public ILogger CreateLogger(LoggerType type);
        }

        enum LoggerType
        {
            CONSOLE_LOGGER = 0,
            FILE_LOGGER = 1
        }

        class LoggerFactory : ILoggerFactory
        {
            public ILogger CreateLogger(LoggerType type)
            {
                switch (type)
                {
                    case LoggerType.CONSOLE_LOGGER: return new ConsoleLogger();
                    case LoggerType.FILE_LOGGER: return new FileLogger();
                    default: return new ConsoleLogger();
                }
            }
        }

        interface IObjectPrinterFactory
        {
            public IObjectPrinter CreateObjectPrinter(PrinterType type); 
        }

        enum PrinterType
        {
            CONSOLE_PRINTER = 0,
            FILE_PRINTER = 1
        }

        class ObjectPrinterFactory : IObjectPrinterFactory
        {
            public IObjectPrinter CreateObjectPrinter(PrinterType type)
            {
                switch (type)
                {
                    case PrinterType.CONSOLE_PRINTER: return new ConsoleObjectPrinter();
                    default: return new ConsoleObjectPrinter();
                }
            }
        }
    }
}

