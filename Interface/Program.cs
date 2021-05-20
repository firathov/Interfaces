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
            Console.WriteLine($"\n{ITool.Key}: Guitar is Playing with {chordQuantity} Chords\n");
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
            Console.WriteLine($"\n{ITool.Key}: Drum is Playing with Size = {size}\n");
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
            Console.WriteLine($"\n{ITool.Key}Trumpet is playing with Diametr = {diametr}\n");
        }
    }

    class Program
    {
        private static int chordQuantity;

        static void Main(string[] args)
        {
            //Console.Write("Write chords quantity: ");
            //int chordQuantity = ForNumberCheck();
            //Guitar guitar = new Guitar(chordQuantity);

            //Console.Write("Write size of Drum: ");
            //int size = ForNumberCheck();
            //Drum drum = new Drum(size);

            //Console.Write("Write diametr of Trumpet: ");
            //int diametr = ForNumberCheck();
            //Trumpet trumpet = new Trumpet(diametr);

            ITool[] tools = new ITool[3];
            //tools[0] = new Guitar (chordQuantity);
            //tools[1] = new Drum (size);
            //tools[2] = new Trumpet(diametr);

            //for (int i = 0; i < tools.Length; i++)
            //{
            //    tools[i].Play();
            //}
            bool exit = true;
            do
            {
                Menu();
                Console.Write("Choose the tools: ");
                int switcher = ForNumberCheck();
                switch (switcher)
                {
                    case 1:
                        {
                            Console.Write("Write chords quantity: ");
                            int chordQuantity = ForNumberCheck();
                            tools[0] = new Guitar(chordQuantity);
                            tools[0].Play();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Write size of Drum: ");
                            int size = ForNumberCheck();
                            tools[1] = new Drum(size);
                            tools[1].Play();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Write diametr of Trumpet: ");
                            int diametr = ForNumberCheck();
                            tools[2] = new Trumpet(diametr);
                            tools[2].Play();
                            break;
                        }
                    case 4:
                        {
                            exit = false;
                            Console.WriteLine("Good Luck, have a nice day/night");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("There is no this kind of choice\n");
                            break;
                        }

                }
            }
            while (exit == true) ;

            Console.ReadKey();


        }

        public static void Menu()
        {
            Console.WriteLine("1) Guitar");
            Console.WriteLine("2) Drum");
            Console.WriteLine("3) Trumpet");
            Console.WriteLine("4) Exit");
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
                    Console.Write("You wrote the wrong symbol, pls try again: \n");
                }
            }
        }
    }
}
