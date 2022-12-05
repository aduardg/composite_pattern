
namespace ItemMinecraft
{
    class Program
    {
        static Iitem IronItem = new Item() { Name = "Железо" };
        static Iitem Cooper = new Item() { Name = "Слиток меди" };
        static Iitem Tin = new Item() { Name = "Олово" };
        static Iitem SolarDust = new Item() { Name = "Светопыль" };
        static Iitem Lazury = new Item() { Name = "Лазурит" };
        static Iitem RedStone = new Item() { Name = "Красная пыль" };
        static Iitem Latex = new Item() { Name = "Латекс" };
        static Iitem Glass = new Item() { Name = "Стекло" };
        static Iitem Coal = new Item() { Name = "Уголь" };
        static Iitem Stone = new Item() { Name = "Камень" };

        public static void Main(string[] args)
        {
            getAdvancedSolarPanel();
        } 

        public static void getAdvancedSolarPanel()
        {
            //Печь
            Iitem Bake = new Item() { Name = "Печь" };
            Bake.addItem(Stone, 8);

            //Машинный блок
            Iitem MachineBlock = new Item() { Name = "Машинный блок" };
            MachineBlock.addItem(IronItem, 8);

            //Батарейка
            Iitem Battery = new Item() { Name = "Батарейка" };
            Battery.addItem(Latex, 0.3d);
            Battery.addItem(Cooper, .5d);
            Battery.addItem(Tin, 4);
            Battery.addItem(RedStone, 2);

            //Generator
            Iitem Generator = new Item() { Name = "Генератор" };
            Generator.addItem(Bake, 1);
            Generator.addItem(MachineBlock, 1);
            Generator.addItem(Battery, 1);

            //Микросхема
            Iitem MicroChema = new Item() { Name = "Микросхема" };
            MicroChema.addItem(Cooper, 3);
            MicroChema.addItem(Latex, 2);
            MicroChema.addItem(RedStone, 2);
            MicroChema.addItem(IronItem, 1);

            //SolarPanel
            Iitem SolarPanel = new Item() { Name = "Солнечная панель" };
            SolarPanel.addItem(MicroChema, 2);
            SolarPanel.addItem(Generator, 1);
            SolarPanel.addItem(Coal, 3);
            SolarPanel.addItem(Glass, 3);

            //Улучшенная микросхема
            Iitem AdvancedMicroChema = new Item() { Name = "Улучшенная микросхема" };
            AdvancedMicroChema.addItem(MicroChema, 1);
            AdvancedMicroChema.addItem(RedStone, 4);
            AdvancedMicroChema.addItem(SolarDust, 2);
            AdvancedMicroChema.addItem(Lazury, 2);

            //Угольная пластина
            Iitem CoalPlaste = new Item() { Name = "Угольная пластина" };
            CoalPlaste.addItem(Coal, 8);

            //Bronze
            Iitem Bronze = new Item() { Name = "Бронза" };
            Bronze.addItem(Cooper, 1.5d);
            Bronze.addItem(Tin, .5d);

            //AdvancedAlloy(Защищенная падушка)
            Iitem AdvancedAlloy = new Item() { Name = "Защищенная падушка" };
            AdvancedAlloy.addItem(IronItem, 1.5d);
            AdvancedAlloy.addItem(Tin, 1.5d);
            AdvancedAlloy.addItem(Bronze, 1.5d);


            //Улучшенный машинный блок
            Iitem AdvancedMashineBlock = new Item() { Name = "Улучшенный машинный блок" };
            AdvancedMashineBlock.addItem(MachineBlock, 1);
            AdvancedMashineBlock.addItem(AdvancedAlloy, 2);
            AdvancedMashineBlock.addItem(CoalPlaste, 2);

            //AdvancedGlass
            Iitem AdvancedGlass = new Item() { Name = "Улучшенное стекло" };
            AdvancedGlass.addItem(Glass, 1);
            AdvancedGlass.addItem(AdvancedAlloy, 0.28d);

            //advancedSolarPanel!!!
            Iitem AdvancedSolarPanel = new Item() { Name = "Улучшенная солнечная панель" };
            AdvancedSolarPanel.addItem(AdvancedGlass, 3);
            AdvancedSolarPanel.addItem(AdvancedAlloy, 2);
            AdvancedSolarPanel.addItem(SolarPanel, 1);
            AdvancedSolarPanel.addItem(AdvancedMicroChema, 2);
            AdvancedSolarPanel.addItem(AdvancedMashineBlock, 1);

            //AdvancedSolarPanel.display(1, 0);
            List<(string, double)> listicElems = new List<(string, double)>();
            listicElems.Add(("Железо", 0));
            listicElems.Add(("Слиток меди", 0));
            listicElems.Add(("Олово", 0));
            listicElems.Add(("Светопыль", 0));
            listicElems.Add(("Лазурит", 0));
            listicElems.Add(("Красная пыль", 0));
            listicElems.Add(("Латекс", 0));
            listicElems.Add(("Стекло", 0));
            listicElems.Add(("Уголь", 0));
            listicElems.Add(("Камень", 0));

            MicroChema.GetElemsCount(32, listicElems);

            foreach ((string, double) elem in listicElems)
            {
                Console.WriteLine($"{elem.Item1} : {elem.Item2}");
            }

            Console.ReadLine();

        }
    }
}