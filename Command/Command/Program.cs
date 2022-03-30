
using Command;

class Program
{
    public static int x = 0;
    public static int y = 0;

    static void main(String[] args)
    {
        var commandlist =new List<ICommand>();
        Console.WriteLine("Use Arrows to add direction command,and Enter to run the command list");
         while(true)
        {
            var key = Console.ReadKey(true).Key;
            if(key == ConsoleKey.UpArrow)
                commandlist.Add(new UpCommand());
            else if (key == ConsoleKey.DownArrow)
                commandlist.Add(new DownCommand());
            else if (key == ConsoleKey.LeftArrow)
                commandlist.Add(new DownCommand());
            else if (key == ConsoleKey.RightArrow)
                commandlist.Add(new DownCommand());
            else if (key == ConsoleKey.Enter)
            {
                Console.WriteLine();
                commandlist.ForEach(c=>c.Invoke());
                Console.WriteLine($":{x}, {y}");
                commandlist.Clear();
            }
        }
    }
}
