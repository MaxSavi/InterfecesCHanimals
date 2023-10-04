public interface IAnimal
{
    string CatMakeSound();
    string DogMakeSound();
}

class A : IAnimal
{
    string My_x, My_y;

    public string x
    {
        set { My_x = value; }
        get { return My_x; }
    }
    public string y
    {
        set { My_y = value; }
        get { return My_y; }
    }

    public A() { }
    public A(string x, string y)
    {
        this.x = x;
        this.y = y;
    }
    public virtual string CatMakeSound()
    {
        return x;
    }
    public virtual string DogMakeSound()
    {
        return y;
    }
    public virtual void rewrite()
    {
        Console.WriteLine("Звук кошки x: {0}\nЗвук собаки y: {1}", x, y);
    }
}


class Program
{
    static void Main()
    {
        A obj1 = new A(x: "мяу", y: "гав");
        obj1.rewrite();
        Console.WriteLine("Кошка издает звук: {0}", obj1.x);
        Console.WriteLine("Собака издает звук: {0}", obj1.y);

        Console.ReadLine();
    }
}

