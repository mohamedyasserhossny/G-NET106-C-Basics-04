namespace assigment_4_route
{
    internal class Program
    {
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        public static void printbooktitle(string title)
        {
            Console.WriteLine($"book title{ title}");
        }
        public static void addbounspages(int pages)
        {
            pages = pages + 50;
            Console.WriteLine(pages);
        }
        public static void ApplyDiscount(double[] prices)
        {
            prices[0] = prices[0] - 5;
            Console.WriteLine(prices[0]);
        }
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
            #region question3 
            PrintWelcomeMessage();
            #endregion

            #region question 4
            string title = "bbb";
            printbooktitle(title);
            #endregion
            #region QUESTION 5
            int pages = 400;
            addbounspages(pages);

            #endregion
            #region question6
            double[] prices = { 25.5, 40.0 };
            ApplyDiscount(prices);
            #endregion



        }
    }
}
