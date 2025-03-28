// See https://aka.ms/new-console-template for more information
UserService.GetSomePeople(2);


internal class UserService
{
    private static IEnumerable<User> GetUsersList(int number){
        
            yield return new User("Ahmet", "Çalışkan");
            yield return new User("Seçil", "Çalışkan");
            yield return new User("Bilge", "Çalışkan");
            yield return new User("İsmail", "Çalışkan");
    }
    public static void GetSomePeople(int number)
    {
        var list = GetUsersList(number);


        for (int i = 0; i < number; i++)
        {
            list.ToArray();
        }
        
    }
}

internal class User
{
    public User(string Name, string SurName, int Age)
    {
        Name = this.Name;
        SurName = this.SurName;
        Age = this.Age;
    }

    public User(string Name, string SurName)
    {
        Console.WriteLine($"{Name}/{SurName}");
    }

    public string Name { get; set; }
    public string SurName { get; set; }
    public int Age { get; set; }
}