using System.Runtime.ExceptionServices;
using System.Security.AccessControl;

namespace this_is_nit_a_product_of_love_2
{
    internal class Program
    {
        static double[] octave2 = { 65.41, 69.3, 73.42, 77.78, 82.41, 87.31, 92.5, 98.00, 103.8, 110.00, 116.5, 123.5 };
        static double[] octave3 = { 130.8, 138.6, 146.8, 155.6, 164.8, 174.6, 185.00, 196.00, 207.7, 220.00, 233.1, 246.9 };
        static double[] octave4 = { 261.6, 277.2, 293.7, 311.1, 329.6, 349.2, 370.0, 392.0, 415.3, 440.0, 466.2, 493.9 };
        static double[] octave5 = { 523.3, 554.4, 587.3, 622.3, 659.3, 698.5, 740.0, 784.0, 830.6, 880.0, 932.3, 987.8 };
        static double[] octave6 = { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
        static double[] octave7 = { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
        static double[] octave8 = { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };

        public static void ChangeOctave(ConsoleKey octave)
        {       
            if (octave == ConsoleKey.F3)
            {
                Console.WriteLine("октава 2");
                Choosetheklavisha(octave2);
            }
            if (octave == ConsoleKey.F4)
            {
                Console.WriteLine("октава 3");
                Choosetheklavisha(octave3);
            }
            if (octave == ConsoleKey.F5)
            {
                Console.WriteLine("октава 4");
                Choosetheklavisha(octave4);
            }
            if (octave == ConsoleKey.F6)
            {
                Console.WriteLine("октава 5");
                Choosetheklavisha(octave5);
            }
            if (octave == ConsoleKey.F7)
            {
                Console.WriteLine("октава 6");
                Choosetheklavisha(octave6);
            }
            if (octave == ConsoleKey.F8)
            {
                Console.WriteLine("октава 7");
                Choosetheklavisha(octave7);
            }
            if (octave == ConsoleKey.F9)
            {
                Console.WriteLine("октава 8");
                Choosetheklavisha(octave8);
            }
            else
            {

            }
        }

        static void Choosetheklavisha(double[] a)
        {
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.D)
                {
                    Console.Beep((int)a[0], 700);   //до
                }
                if (key.Key == ConsoleKey.R)
                {
                    Console.Beep((int)a[1], 700);   //до диез
                }
                if (key.Key == ConsoleKey.F)
                {
                    Console.Beep((int)a[2], 700);   //ре
                }
                if (key.Key == ConsoleKey.T)
                {
                    Console.Beep((int)a[3], 700);   //ре диез
                }
                if (key.Key == ConsoleKey.G)
                {
                    Console.Beep((int)a[4], 700);   //ми
                }
                if (key.Key == ConsoleKey.H)
                {
                    Console.Beep((int)a[5], 700);   //фа
                }
                if (key.Key == ConsoleKey.U)
                {
                    Console.Beep((int)a[6], 700);   //фа диез
                }
                if (key.Key == ConsoleKey.J)
                {
                    Console.Beep((int)a[7], 700);   //соль
                }
                if (key.Key == ConsoleKey.I)
                {
                    Console.Beep((int)a[8], 700);   //соль диез
                }
                if (key.Key == ConsoleKey.K)
                {
                    Console.Beep((int)a[9], 700);   //ля
                }
                if (key.Key == ConsoleKey.O)
                {
                    Console.Beep((int)a[10], 700);   //ля диез
                }
                if (key.Key == ConsoleKey.L)
                {
                    Console.Beep((int)a[11], 700);   //си
                }
                else
                {

                }
            } while (key.Key != ConsoleKey.Spacebar);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Смена октав ведется по кнопкам F3 - F9. Всего семь октав, F3 отвечает за вторую. \n");
            Console.WriteLine("Управление клавишами пианино происходит с помощью данных кнопок клавиатуры: \n");
            Console.WriteLine("  R   T     U   I   O");
            Console.WriteLine("D   F   G H   J   K   L\n");
            Console.WriteLine("Нажатие spacebar даст вам мозможность выбрать октаву заново.\n Нажатие escape закрывают программу.");
            Console.WriteLine("Выберите октаву:");
            ConsoleKey maink = Console.ReadKey().Key;

            do
            {
                
                ChangeOctave(maink);
                maink = Console.ReadKey().Key;
            }
            while (maink != ConsoleKey.Escape);
        }
    }
}