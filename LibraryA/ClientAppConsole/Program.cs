using LibraryA;
Calculator c= new Calculator();
Book b= new Book();
Console.WriteLine(c.Add(5, 5));
Console.WriteLine(c.Multiply(5, 5));
Console.WriteLine(c.Divide(5, 5));
b.Title="Harry Potter";
b.Author = "J.K.Rowling";
b.Genre = "Fantasy";
b.BookPrice = 400;
b.BookMarkagePage(350);
Console.WriteLine(b.GetCurrentPage());


