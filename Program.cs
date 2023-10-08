using System;
using System.Threading;

class Program
{
    static int[] secondOctave = new int[] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
    static int[] threeOctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 831, 880, 932, 988 };
    static int currentOctave = 1;

    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в симуляцию пианино");
        Console.WriteLine("Для игры нажимайте на кнопки ниже:");
        Console.WriteLine("A-S-D-F-G-H-J-K-L-Z-X-C");
        Console.WriteLine("Для переключения меджу октавами нажимайте F5, F6");
        

        static int GetNoteIndex(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.A:
                    return 0;
                case ConsoleKey.S:
                    return 1;
                case ConsoleKey.D:
                    return 2;
                case ConsoleKey.F:
                    return 3;
                case ConsoleKey.G:
                    return 4;
                case ConsoleKey.H:
                    return 5;
                case ConsoleKey.J:
                    return 6;
                case ConsoleKey.K:
                    return 7;
                case ConsoleKey.L:
                    return 8;
                case ConsoleKey.Z:
                    return 9;
                case ConsoleKey.X:
                    return 10;
                case ConsoleKey.C:
                    return 11;
                default:
                    return -1;
            }
        }

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

            
            if (key.Key == ConsoleKey.F5)
            {
                currentOctave = 2;
                Console.WriteLine("2 октава");
            }
            else if (key.Key == ConsoleKey.F6)
            {
                currentOctave = 3;
                Console.WriteLine("3 октава");
            }
            else
            {
                int noteIndex = GetNoteIndex(key.Key);
                if (noteIndex != -1)
                {
                    int frequency = GetFrequency(noteIndex);
                    Console.Beep(frequency, 300);
                }
            }
        }
    }
}
static int GetFrequency(int noteIndex)
{
    int[] octave = GetOctave(currentOctave);
    return octave[noteIndex];
}
static int[] GetOctave(int octaveNumber)
{
    switch (octaveNumber)
    {

        case 1:
            return secondOctave;
        case 2:
            return threeOctave;
        default:
            return secondOctave;
    }
}



    

    
}
