using System;

namespace Interface
{
    interface ITool
    {
        public static string key = "До мажор";
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
            Console.WriteLine($"\nGuitar is Playing with {chordQuantity} Chords");
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
            Console.WriteLine($"\nDrum is Playing with Size = {size}");
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
            Console.WriteLine($"\nTrumpet is playing with Diametr = {diametr}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write chords quantity: ");
            int chordQuantity = forNumberCheck();
            Guitar guitar = new Guitar(chordQuantity);

            Console.Write("Write size of Drum: ");
            int size = forNumberCheck();
            Drum drum = new Drum(size);

            Console.Write("Write diametr of Trumpet: ");
            int diametr = forNumberCheck();
            Trumpet trumpet = new Trumpet(diametr);
            

            ITool[] tools = new ITool[2];
            tools[0] = new Guitar(chordQuantity);
            tools[1] = new Drum(size);
            tools[2] = new Trumpet(diametr);

            for (int i = 0; i < tools.Length-1; i++)
            {
                tools[i].Play();
            }



            static int forNumberCheck()
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
                        Console.Write("Вы ввели неправильный символ, попробуйте ещё: ");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
