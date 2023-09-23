namespace LibraryA
{
    public class Book
    {
        public String Title = String.Empty;
        public String Author=String.Empty; 
        public String Genre = String.Empty;
        public DateTime DateofPublish;
        public int BookPrice;
        public int TotalPages = 300;
        public void OpenBook()
        {
            Console.WriteLine("Book is Open");
        }
        public void BookMarkagePage(int PageNo)
        {
            Console.WriteLine($"Page No.{PageNo} has been bookmarked");
        }
        public int GetCurrentPage()
        {
            Random r= new Random();
            return r.Next(TotalPages);
        }
        public void CloseBook() 
        {
            Console.WriteLine("Book is Closed");
        }


    }
}