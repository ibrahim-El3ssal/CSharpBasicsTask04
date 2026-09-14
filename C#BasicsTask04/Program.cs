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

            #region Question 06  
            // 6 - Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
            // with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to see, and why?
            Console.WriteLine("\nQuestion06 : ");
            double[] bookPrices = { 25.5, 40.0 };
            Console.WriteLine($"Before Method: {bookPrices[0]}"); //  25.5
            ApplyDiscount(bookPrices);                           //  20.5
            Console.WriteLine($"After Method: {bookPrices[0]}");  //  20.5

            // passing Parameter by value (Refernce Type )
            // take copy of address value in heap to method and change on original value of array heap
            #endregion

            #region Question 07 
            //7 - Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //Call it and print pages afterward. How is the result different from question 5 ?
            Console.WriteLine("\nQuestion07 : ");
            int pages2 = 400;
            Console.WriteLine($"Before Method: {pages2}"); //  400
            AddBonusPagesByRef(ref pages2);                         // 450
            Console.WriteLine($"After Method: {pages2}");  // 450

            // passing Parameter by Refernce  (value Type )
            // take ref of value in stack to method and change on original value in stack
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

        /// Question 06: 
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
            Console.WriteLine(prices[0]);
        }

        /// Question 07: 
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
            Console.WriteLine($"inside Method: {pages}");
        }
    }


}
