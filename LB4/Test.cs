using LB4.FlowerShop;
using LB4.Factories;
using LB4.Loggers;
using LB4.Printers;

static class Test
{
    public static void Main(string[] args)
    {
        LoggerFactory loggerFactory = new LoggerFactory();
        AbstractFlowerFactory flowerFactory = new AbstractFlowerFactory();
        WrapperFactory wrapperFactory = new WrapperFactory();   
        BouquetFactory bouquetFactory = new BouquetFactory();
        ObjectPrinterFactory printerFactory = new ObjectPrinterFactory();

        ILogger logger = loggerFactory.CreateLogger(LoggerType.FILE_LOGGER);
        IObjectPrinter printer = printerFactory.CreateObjectPrinter(PrinterType.CONSOLE_PRINTER);
        logger.Start();
        logger.Log("Создал фабрики и объекты Logger и Printer");
        AbstractFlower[] flowers = new AbstractFlower[] {
            flowerFactory.CreateRose("White", 100),
            flowerFactory.CreateRose("White", 100),
            flowerFactory.CreateRose("White", 100),
            flowerFactory.CreateRose("Red", 150),
            flowerFactory.CreateRose("Red", 150),
            flowerFactory.CreateRose("Red", 150)
        };
        logger.Log("Создал массив цветов:");
        foreach (AbstractFlower flower in flowers)
        {
            printer.Print(flower.ToString());
            logger.Log(flower.ToString());
        }
        

        Wrapper wrapper = wrapperFactory.CreateWrapper("Paper", 100);
        logger.Log("Создал обёртку:");
        printer.Print(wrapper.ToString());
        logger.Log(wrapper.ToString());

        Bouquet bouquet1 = bouquetFactory.Create(wrapper, flowers);
        logger.Log("Создал 1 букет из массива цветов:");
        printer.Print(bouquet1.ToString());
        logger.Log(bouquet1.ToString());

        Bouquet bouquet2 = bouquetFactory.Create(wrapper);
        logger.Log("Создал 2 букет:");
        printer.Print(bouquet2.ToString());
        logger.Log(bouquet2.ToString());

        bouquet2.addFlower(flowerFactory.CreateTulpin("Yellow", 200));
        bouquet2.addFlower(flowerFactory.CreateTulpin("Yellow", 200));
        bouquet2.addFlower(flowerFactory.CreateTulpin("Orange", 250));
        bouquet2.addFlower(flowerFactory.CreateTulpin("Orange", 250));
        logger.Log("Добавил во 2 букет цветы");
        printer.Print(bouquet2.ToString());
        logger.Log(bouquet2.ToString());
        logger.End();
    }
}
