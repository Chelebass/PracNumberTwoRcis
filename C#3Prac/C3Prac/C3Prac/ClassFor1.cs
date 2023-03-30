namespace C3Prac;

class Worker
{
    public string name = "";
    public string surname = "";
    public int rate;
    public int days;

    public int GetSalary()
    {
        return this.rate * this.days;
    }
}