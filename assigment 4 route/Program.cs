using System.Diagnostics;

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
        //public static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] = prices[0] - 5;
        //    Console.WriteLine(prices[0]);
        //}
       public  static void AddBonusPagesByRef(ref int pages)
        {
            pages = pages + 10;
            Console.WriteLine(pages);
        }
        public static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
            Console.WriteLine(prices.Length);
        }
        public static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }

            price = 0;
            return false;
        }

        static void Main(string[] args)
        {
            //#region question1 
            //double[] price = [25.5, 40.0, 33.75];
            //Console.WriteLine(price[1]);
            //#endregion
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
            //int pages = 400;
            //addbounspages(pages);

            #endregion
            #region question6
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            #endregion
            #region question 7
            int pages = 400;
            AddBonusPagesByRef(ref pages);
            #endregion
            #region question 8
            double[] prices = { 25.5, 40.0 };
            ReplaceArray(ref prices);
            #endregion
            #region question 9
            double price;

            if (TryGetPrice("Clean Code", out price))
            {
                Console.WriteLine(price);
            }

            #endregion





        }
    }
}
