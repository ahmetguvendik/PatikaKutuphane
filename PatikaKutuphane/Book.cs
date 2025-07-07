namespace PatikaKutuphane;

public class Book
{
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public string AuthorSurname { get; set; }
    public int PageCount { get; set; }
    public string BookPublisher { get; set; }
    public DateTime CreatedDate { get; set; }  //Property tanimlamalari yapiyoruz 
 
    public Book(string name, string authorName, string authorSurname, int pageCount, string bookPublisher)
    {
        Name = name;
        AuthorName = authorName;
        AuthorSurname = authorSurname;
        PageCount = pageCount;
        BookPublisher = bookPublisher;
        CreatedDate = DateTime.Now;
    }  //Deger alan constructor

    public Book() //Default Constructor
    {
        CreatedDate = DateTime.Now;
    }
}