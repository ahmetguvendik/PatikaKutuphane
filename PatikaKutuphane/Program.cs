using PatikaKutuphane;

Book book = new Book();  //Book class indan bir nesne tanimliyoruz ve deger atamasi yapiyoruz 
book.Name = "Adi Aylin";
book.AuthorName = "Ayse";
book.AuthorSurname = "Kulin";
book.PageCount = 398;
book.BookPublisher = "Remzi Kitabevi";

Console.WriteLine($"{book.Name} -- {book.AuthorName} {book.AuthorSurname} -- {book.PageCount} -- {book.BookPublisher} -- {book.CreatedDate.ToShortDateString()}");

Book book2 = new Book("Son Kitap","Elif","Sahin",275,"Delta Yayincilik"); //Parametreli constructor icersine deger giriyoruz  
Console.WriteLine($"{book2.Name} -- {book2.AuthorName} {book2.AuthorSurname} -- {book2.PageCount} -- {book2.BookPublisher} -- {book2.CreatedDate.ToShortDateString()}");
