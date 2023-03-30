namespace C2Prac;

class Numbers
{
    public int firstNumber = 0;
    public int secondNumber = 0;

    public string justNums(int one, int two)
    {
        return ($"Певое число = {one} \nBторое число = {two}");
    }
    public int numsPlusNums(int first, int second)
    {
        return first += second;
    }
    public int muxNums(int one, int two)
    {
        return one > two ? one : two;
    }
}