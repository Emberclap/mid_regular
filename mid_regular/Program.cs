namespace mid_regular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biscuitsWorkerDoPerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int competitionBiscuits = int.Parse(Console.ReadLine());

            double biscuitsPerDay = Math.Floor(workers * (double)biscuitsWorkerDoPerDay);
            double biscuitsSum = 0;
            for (int i = 0; i < 30; i++)
            {

                if (i % 3 == 0)
                {
                    biscuitsSum += Math.Floor(biscuitsPerDay * 0.75);
                }
                else
                {
                    biscuitsSum += biscuitsPerDay;
                }
            }
            
            double percent = (biscuitsSum - competitionBiscuits) / competitionBiscuits * 100;
            Console.WriteLine($"You have produced {biscuitsSum} biscuits for the past month.");
            if (biscuitsSum > competitionBiscuits)
            {
                Console.WriteLine($"You produce {percent:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {-percent:f2} percent less biscuits.");
            }
        }
    }
}