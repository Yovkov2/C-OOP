


public class Pet : IBirthDate
{
    public Pet(string birthDate, string name)
    {
        BirthDate = birthDate;
        Name = name;
    }

    public string BirthDate { get; private set; }
    public string Name { get; set; }
}