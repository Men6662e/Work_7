class Avtor
{
    public string name = "Здесь имя автора!";
    public string firstName = "Здесь фамилия Автора!";
    public DateTime birth_Day = new DateTime();
    public DateTime death_Day = new DateTime();
    public string genre = "Здесь жанр Автора!";
    public string country = "Здесь происхаждение Автора!";

    public void Print_Autor()
    {
        Console.WriteLine
        (
            $"Имя автора: \t{name}" +
            $"\nВаша фамилия: \t{firstName}" +
            $"\nДата рождения автора:\t{birth_Day}" +
            $"\nДата смерти автора:\t{death_Day}" +
            $"\nЖанр автора:\t{genre}" +
            $"\nПроисхождение автора:\t{country}"
        );
    }
}
