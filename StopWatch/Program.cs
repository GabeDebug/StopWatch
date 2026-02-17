namespace StopWatch
{
    class Program
    {
        static void Main()
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s  = 10 Segundos:");
            Console.WriteLine("M = Minutos => 1m = 1 minuto:");
            Console.WriteLine("0 = Sair:");
            Console.WriteLine("Quanto tempo deseja Contar?");

            string data = Console.ReadLine().ToLower();
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("StopWatch finalizado");
            Thread.Sleep(2500); 
        }
    }
}