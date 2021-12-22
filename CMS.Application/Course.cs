public class Item
{
    public string Name { get; }
    public int Age { get; set; }
    public Item(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
