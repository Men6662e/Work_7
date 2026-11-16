class Book
{
    public string bookName = "Здесь имя книги автора!";
    public string bookAvtor = "Здесь автор книги!";
    public DateTime bookCreateDate = new DateTime();
    public string bookGenre = "Здесь жанр книги!";
    public string bookCountry = "Здесь страна происхождение книги!";

    public void Print_Book()
    {
        Console.WriteLine
        (
            $"Имя книги:\t{bookName}" +
            $"\nАвтор книги:\t{bookAvtor}" +
            $"\nДата написания книги:\t{bookCreateDate}" +
            $"\nЖанр книги:\t{bookGenre}" +
            $"\nСтрана происхождения книги:\t{bookCountry}"
        );
    }
}