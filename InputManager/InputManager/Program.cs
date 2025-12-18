internal class Program
{
    static void OnInput()
    {
        Console.WriteLine("입력 받음");
    }

    static void Main()
    {
        InputManager inputManager = new InputManager();

        inputManager.InputKey += OnInput;

        while (true)
        {
            inputManager.Update();
        }
    }
}
