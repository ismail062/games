using System;
namespace card_deck
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter a number, 1: play, 2:Exit \n");
            int play = Convert.ToInt32(Console.ReadLine());

            Deck game = new Deck();
            try
            {

                while (play != 2)
                {
                    Console.Write("Please Enter a number, 1: New Game, 2: Show Cards, 3: Draw, \n 4: Shuffle, 5: Sort, 6: Quit \n");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {

                        case 1:
                            game = new Deck();
                            game.Show();
                            continue;
                        case 2:
                            game.Show();
                            continue;
                        case 3:
                            game.Draw();
                            continue;
                        case 4:
                            game.Shuffle();
                            continue;
                        case 5:
                            game.Sort();
                            continue;
                        case 6:
                            Console.WriteLine("Have a nice time!");
                            break;
                        default:
                            break;
                    }

                    break;

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
