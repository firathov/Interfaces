using System;

namespace Interface
{
    interface ITool
    {
        public static string Key = "До мажор";
        public void Play();
    }

    class Guitar: ITool
    {
        private int chordQuantity;
        public int ChordQuantity
        {
            get
            {
                return chordQuantity;
            }
            set
            {
                chordQuantity = value;
            }
        }
        public Guitar (int chordQuantity)
        {
            this.chordQuantity = chordQuantity;
        }

        public void Play()
        {
            Console.WriteLine($"\n{ITool.Key}: Guitar is Playing with {chordQuantity} Chords");
        }
    }

    class Drum: ITool
    {
        private int size;
        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public Drum (int size)
        {
            this.size = size;
        }
        public void Play()
        {
            Console.WriteLine($"\n{ITool.Key}: Drum is Playing with Size = {size}");
        }
    }

    class Trumpet: ITool
    {
        private int diametr;
        public int Diametr
        {
            get
            {
                return diametr;
            }
            set
            {
                diametr = value;
            }
        }
        public Trumpet (int diametr)
        {
            this.diametr = diametr;
        }
        public void Play()
        {
            Console.WriteLine($"\n{ITool.Key}Trumpet is playing with Diametr = {diametr}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write chords quantity: ");
            int chordQuantity = ForNumberCheck();
            Guitar guitar = new Guitar(chordQuantity);

            Console.Write("Write size of Drum: ");
            int size = ForNumberCheck();
            Drum drum = new Drum(size);

            Console.Write("Write diametr of Trumpet: ");
            int diametr = ForNumberCheck();
            Trumpet trumpet = new Trumpet(diametr);
            
            ITool[] tools = new ITool[3];
            tools[0] = new Guitar (chordQuantity);
            tools[1] = new Drum (size);
            tools[2] = new Trumpet(diametr);

            for (int i = 0; i < tools.Length; i++)
            {
                tools[i].Play();
            }
            Console.ReadKey();
        }
            static int ForNumberCheck()
            {
                int number;

                for (; ; )
                {
                    string checkingNumber = Console.ReadLine();
                    if (Int32.TryParse(checkingNumber, out number) && number > 0)
                    {
                        return number;
                    }
                    else
                    {
                        Console.Write("You wrote the wrong symbol, pls try again: ");
                    }
                }
            }
    }
}
