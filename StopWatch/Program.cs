namespace StopWatch
{
    class Program
    {
        static void Main()
        {
            Start(6);
        }
        static void Menu()
        {
            
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
        }
    }
}