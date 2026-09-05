namespace assigment_4_route
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1 
            double[] price = [25.5, 40.0, 33.75];
            Console.WriteLine(price[1]);
            #endregion
            #region question2 
            int[,] shelfCopies = new int[2, 2];
            shelfCopies[0, 0] = 3;
            shelfCopies[0, 1] = 5;
            shelfCopies[1, 0] = 1;
            shelfCopies[1, 1] = 4;
            for(int rows=0;rows<shelfCopies.GetLength(0);rows++)
            {
                for(int col=0;col<shelfCopies.GetLength(1);col++)
                {
                    Console.Write($"{shelfCopies[rows, col]}");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
