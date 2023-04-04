namespace Arry_SUM_MULTI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Enter ROW number=>  ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter Column number=>  ");
            int column = int.Parse(Console.ReadLine());
            int[][] arry1 = new int[row][];
            for (int i = 0; i < arry1.Length; i++)
            {
                arry1[i] = new int[column];
                for (int j = 0; j < arry1[i].Length; j++)
                {
                    arry1[i][j] = random.Next(1, 10);
                    Console.Write($" {arry1[i][j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Result Sum=> ");
            Sum(arry1);
            Console.WriteLine();
            Console.WriteLine("Result Multiplication=> ");
            Multiplication(arry1);

            Main(args);
        }
        public static void Sum(int[][] arry)
        {
            int sum;
            for (int i = 0; i < arry.Length; i++)
            {
                sum = 0;
                for (int j = 0; j < arry[i].Length; j++)
                {
                    sum += arry[i][j];
                }
                Console.Write($"{sum} ");
            }
        }
        public static void Multiplication(int[][] arry)
        {
            int sumMulti = 1;
            for (int i = 0; i < arry.Length; i++)
            {
                sumMulti = 1;
                for (int j = 0; j < arry[i].Length; j++)
                {
                    sumMulti *= arry[i][j];
                }
                Console.Write($"{sumMulti} ");
            }

        }
    }
}