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

            #region Question 03  
            // 3 - Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!". Call it from Main.
            Console.WriteLine("\nQuestion03 : ");
            PrintWelcomeMessage();
            #endregion

            #region Question 04 
            // 4 - Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".
            Console.WriteLine("\nQuestion04 : ");
            PrintBookTitle("Clean Code");
            #endregion

            #region Question 05  
            // 5-Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            // int pages = 400; and print pages afterward. What do you expect to see, and why?
            Console.WriteLine("\nQuestion05 : ");
            int pages = 400;
            Console.WriteLine($"Before Method: {pages}"); //  400
            AddBonusPages(pages);                         // 450
            Console.WriteLine($"After Method: {pages}");  // 400

            // passing Parameter by value (Value Type )
            // take copy of frame to method and change on this frame only , original value of pages not change 

            #endregion
        }

        //               Methods Declaration Outside Main Function

        /// Question 03: 
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        /// Question 04: 
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }
        /// Question 05: 
        static void AddBonusPages(int pages)
        {
            Console.WriteLine($"inside Method: {pages + 50}");
        }
    }


}
