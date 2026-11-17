namespace C__Basics_Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q01
            //object Book1 = new Book();
            //Console.WriteLine(Book1);
            #endregion

            #region Q02
            //Console.WriteLine(Book1.ToString());
            //Console.WriteLine(Book1.Equals(Book1));
            //Console.WriteLine(Book1.GetHashCode());
            //Console.WriteLine(Book1.GetType());
            #endregion

            #region Q03
            //// Error Type: Compile-time error
            //int Pages =int.TryParse("464",out int fix)? fix:0;
            //Console.WriteLine(Pages);
            #endregion

            #region Q04
            //int x = 10;
            //int y = 0;
            //try { 
            //    int z = x / y;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");            
            //}
            #endregion

            #region Q05
            //int Pages = 300;
            //double PagesDouble = Pages;
            #endregion

            #region Q06

            //double price = 49.99;
            //int iPrice = (int)price;

            #endregion

            #region Q07

            //string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText);

            #endregion

            #region Q08

            //string yearText = "2023";
            //int Year = int.Parse(yearText);
            //string badText = "abc";
            //if (int.TryParse(badText, out int result))
            //{
            //    Console.WriteLine($"Parsed value: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}

            #endregion

            #region Q09

            //int pages = 464;
            //Console.WriteLine(pages.ToString());
            //Console.WriteLine(pages.ToString().GetType());

            #endregion

            #region Q10

            //int copies = 100;
            //object objCopies = copies;
            //int NewInt = (int)objCopies;
            //Console.WriteLine(objCopies);
            //Console.WriteLine(NewInt);

            #endregion

            #region Q11

            //int? year = null;
            //Console.WriteLine(year);
            //year = 2023;
            //Console.WriteLine(year);

            #endregion

            #region Q12

            //string? reviewer = null;
            //if(reviewer is null)
            //{
            //    Console.WriteLine("Reviewer is null");
            //}
            //else
            //{
            //    Console.WriteLine(reviewer);
            //}

            #endregion

            #region Q13

            //Book? book = null;
            //string? title = book?.Title;
            //Console.WriteLine(title);

            #endregion

            #region َQ14

            //Console.WriteLine(title ?? "Untitled");
            //title ??= "Untitled";
            //Console.WriteLine(title);

            #endregion

            #region Q15
            //string? name = "Ahmed";
            //string confirmedName = name!;
            //Console.WriteLine(confirmedName);
            #endregion
        }
    }
}
