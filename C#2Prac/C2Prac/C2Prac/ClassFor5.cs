namespace C2Prac;

class Names
{
    public String FirstName;
    public String Surname;
    public Names()
    {
        this.FirstName = "Александр";
        this.Surname = "Помыткин";
    }
    public Names(String name1, String name2)
    {
        this.FirstName = name1;
        this.Surname = name2;
    }
    ~Names()
    {
        Console.Write($"{this.FirstName} was deleted");
        Console.Write($"\n{this.Surname} was deleted");
    }
}