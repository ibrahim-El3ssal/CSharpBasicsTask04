namespace C_BasicsTask04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01 
            // 1-Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price (index 1).
            Console.WriteLine("Question01  : ");
            double[] itemPrices = new double[] { 25.5, 40.0, 33.75 };
            Console.WriteLine(itemPrices[1]);
            #endregion

            #region Question 02  
            // 2 - Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            // shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.
            Console.WriteLine("\nQuestion02 : ");
            int[,] shelfCopies = new int[,]
            {
                { 3, 5 },
                { 1, 4 }
            };
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion


        }
    }
}
