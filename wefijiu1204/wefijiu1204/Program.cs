internal class Program
{
    //public class Wizard
    //{
    //    public int mp;
    //    public int intelligence;

    //    public Wizard(int mp, int intelligence)
    //    {
    //        this.mp = mp;
    //        this.intelligence = intelligence;
    //    }
    //}
    //    static void Main()
    //    {
    //        Wizard wizard = new Wizard(50, 20);
    //        Console.WriteLine($" MP: {wizard.mp}, INT: {wizard.intelligence}");
    //    }
    public class Wizard
    {
        public int mp;
        public int intelligence;

        public Wizard()
        {
            mp = 50;
            intelligence = 20;
        }
    }
    static void Main()
    {
        Wizard wizard = new Wizard();
        Console.WriteLine($" MP: {wizard.mp}, INT: {wizard.intelligence}");
    }
}

