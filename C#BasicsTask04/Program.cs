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

            #region Question 08  
            // 8 - Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            //new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length afterward.
            Console.WriteLine("\nQuestion08 : ");
            double[] OldPrices = { 25.5, 40.0 };
            Console.WriteLine($"Before Method: {OldPrices.Length}"); //  2
            ReplaceArray(ref OldPrices);
            Console.WriteLine($"After Method: {OldPrices.Length}"); //  3

            // passing Parameter by Refernce  (Refernce Type )
            // take ref of address in stack to array in heap and change add new array to address also don't pointer to old array 
            #endregion

            #region Question 09 
            // 1 - Write a method bool TryGetPrice(string title, out double price) that returns
            //true and sets price to 25.5 if title is "Clean Code", otherwise returns false and
            //sets price to 0.Call it and print the price if found
            Console.WriteLine("\nQuestion09 : ");

            if (TryGetPrice("Clean Code", out double price))
            {
                Console.WriteLine($"Price Found: {price}"); // 25.5
            }
            else
            {
                Console.WriteLine("Price Not Found!");
            }
            #endregion

            #region Question 10
            //2 - Write a method PrintBookInfo(string title, int pages = 300) where pages is
            //optional.Call it once with only a title, and once passing both a title and pages.
            Console.WriteLine("\nQuestion10 : ");

            PrintBookInfo("Book01");
            PrintBookInfo("Book02", 200);

            #endregion

            #region Question 11
            //3 - Using the PrintBookInfo method from the question above, call it by naming
            //the parameters, passing pages before title.
            Console.WriteLine("\nQuestion11 : ");

            PrintBookInfo(pages: 400, title: "Book03");
            #endregion

            #region Question 12
            //4 - Write a method PrintAllTitles(params string[] titles) that prints each title on its own line.
            // Call it with three book titles. 
            Console.WriteLine("\nQuestion12 : ");

            PrintAllTitles("Book01", "Book02", "Book03");
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
        /// Question 08:
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }

        ///Question 09 
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }

        ///Question 10 
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"{title} , {pages}");
        }

        /// Question 12
        static void PrintAllTitles(params string[] titles)
        {
            foreach (var item in titles)
            {
                Console.WriteLine($"{item}");
            }
        }
   
    }


}
