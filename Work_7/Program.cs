void vacuum()
{
    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
}

void book()
{
    Console.WriteLine("--------------------------------------------- Книга ---------------------------------------------------");
}

void avtor()
{
    Console.WriteLine("-------------------------------------------- Писатель -------------------------------------------------");
}

void epizod()
{
    Console.WriteLine("--------------------------------------------- Конец ---------------------------------------------------");
}

Avtor pushkin = new Avtor();
Avtor lermontov = new Avtor();
Avtor blok = new Avtor();

Book pushkinBook = new Book();
Book lermontovBook = new Book();
Book blokBook = new Book();


pushkin.name = "Александр";
pushkin.firstName = "Пушкин";
pushkin.birth_Day = new DateTime(1799, 05, 26);
pushkin.death_Day = new DateTime(1837, 12, 29);
pushkin.genre = "Роман";
pushkin.country = "Российская империя";
pushkinBook.bookName = "Евгений Онегин";
pushkinBook.bookAvtor = "Александр Сергеевич Пушкин";
pushkinBook.bookCreateDate = new DateTime(1823, 05, 09);
pushkinBook.bookGenre = "Роман";
pushkinBook.bookCountry = "Россия";

lermontov.name = "Михаил";
lermontov.firstName = "Лермонтов";
lermontov.birth_Day = new DateTime(1814, 10, 15);
lermontov.death_Day = new DateTime(1841, 07, 27);
lermontov.genre = "Роман";
lermontov.country = "Москва, Российская империя";
lermontovBook.bookName = "Герой нашего времени";
lermontovBook.bookAvtor = "Михаил Юрьевич Лермонтов";
lermontovBook.bookCreateDate = new DateTime(1840, 02, 19);
lermontovBook.bookGenre = "Социально‑психологический роман";
lermontovBook.bookCountry = "Россия";


blok.name = "Александр";
blok.firstName = "Блок";
blok.birth_Day = new DateTime(1880, 11, 28);
blok.death_Day = new DateTime(1921, 08, 07);
blok.genre = "Драма";
blok.country = "Санкт‑Петербург, Российская империя";
blokBook.bookName = "Двенадцать";
blokBook.bookAvtor = "Александр Александрович Блок";
blokBook.bookCreateDate = new DateTime(1918, 01, 08);
blokBook.bookGenre = "Лиро-эпическое произведение";
blokBook.bookCountry = "Россия";

vacuum();
avtor();
vacuum();
pushkin.Print_Autor();
vacuum();
book();
vacuum();
pushkinBook.Print_Book();
vacuum();
avtor();
vacuum();
lermontov.Print_Autor();
vacuum();
book();
vacuum();
lermontovBook.Print_Book();
vacuum();
avtor();
vacuum();
blok.Print_Autor();
vacuum();
book();
vacuum();
blokBook.Print_Book();
vacuum();
epizod();
vacuum();

