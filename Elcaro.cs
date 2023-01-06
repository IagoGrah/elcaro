using System;
using System.Text;

namespace elcaro
{
    public class Elcaro
    {
        private Strings _strings = new Strings(Language.PT);
        private StringBuilder answer = new StringBuilder();
        private int leroCounter;

        public void Run()
        {
            Console.WriteLine(_strings[Strings.GREETING]);

            var lero = _strings[Strings.LERO];
            ConsoleKey input = ConsoleKey.Escape;
            var isWhispering = false;
            while (input != ConsoleKey.Enter)
            {
                input = Console.ReadKey(isWhispering).Key;
                if (input == ConsoleKey.Insert)
                {
                    isWhispering = !isWhispering;
                    continue;
                }

                if (isWhispering)
                {
                    Console.Write(lero[leroCounter]);
                    leroCounter++;
                    if (input == ConsoleKey.Backspace)
                    {
                        answer.Remove(answer.Length - 1, 1);
                    }
                    else
                    {
                        answer.Append(((char)input));
                    }
                }
                else
                {
                    if (input == ConsoleKey.Backspace)
                    {
                        Console.Write(" ");
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(answer.Length > 0 ? answer.ToString() : _strings[Strings.INVALID]);
            Console.ReadKey();
        }
    }
}