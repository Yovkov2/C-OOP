public class Citizen : IDentity, IBirthDate
{
    public Citizen(string id, string name, int age, string birthDate)
    {
        Id = id;
        Name = name;
        Age = age;
        BirthDate = birthDate;
    }

    public string Id { get; private set; }
    public string Name { get; private set; }
    public int Age {  get; private set; }

    public string BirthDate { get; private set; }
}
