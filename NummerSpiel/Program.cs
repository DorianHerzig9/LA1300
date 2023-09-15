using System;
using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace NummerSpiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberGen generator = new NumberGen();
            ScoreCount score = new ScoreCount();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                                                                                                                                          Random Number Generator                                                                                                                                                                                                                                                                                               ");
            Console.BackgroundColor = ConsoleColor.Black;

            generator.Generate();


            string player1Name = "Spieler 1";
            string player2Name = "Spieler 2";
            string currentPlayername = player1Name;
            int player1Guess = 0;
            int player2Guess = 0;
            int scoreingelplayer;
            int scoreplayer1 = 1;
            int scoreplayer2 = 2;


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Wollen Sie zuzweit spielen? (ja/nein)");
            Console.BackgroundColor = ConsoleColor.Black;
            string benutzereingabe = Console.ReadLine();
            if (benutzereingabe == "ja")
            {
                try
                {
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" {0}, wählen Sie eine Zahl zwischen {1} - {2}: ", currentPlayername, generator.min, generator.max);
                        Console.ForegroundColor = ConsoleColor.Green;
                        int guess = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;



                        if (guess == generator.number)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Spieler {0}, Glückwunsch! Sie haben die richtige Zahl gefunden.", currentPlayername);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                        else if (guess > generator.number)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" {0} Ihre Zahl ist zu groß.", currentPlayername);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" {0} Ihre Zahl ist zu klein.", currentPlayername);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        if (currentPlayername == player2Name)
                        {
                            currentPlayername = player1Name;
                        }
                        else
                        { currentPlayername = player2Name; }
                    }

                    Console.WriteLine("Drücke eine beliebige Taste, um das Spiel zu beenden...");
                    Console.ReadKey();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (benutzereingabe == "nein")
            {

                Console.BackgroundColor = ConsoleColor.Black;
                generator.Generate();

                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Wählen Sie eine Zahl zwischen {0} - {1}: ", generator.min, generator.max-1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    int Zahleingabe = Convert.ToInt32(Console.ReadLine());
                    score.counter++;
                    Console.ForegroundColor = ConsoleColor.White;
                    Random rnd = new Random();

                    while (Zahleingabe != generator.number)
                    {
                        if (Zahleingabe > generator.number)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Ihre Zahl ist zu groß.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Ihre Zahl ist zu klein.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.Write(" Geben Sie erneut eine Zahl ein: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Zahleingabe = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;
                        score.counter++;
                    }

                    if (Zahleingabe == generator.number)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" Glückwunsch! Sie haben die richtige Zahl gefunden.");
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" {0} Ihr Score beträgt {1}", currentPlayername, score.counter);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else { Console.WriteLine("Falsche Eingabe"); }
        }
    }
}
