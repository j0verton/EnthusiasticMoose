using System;
using System.Collections.Generic;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("| Player | Computer|");
            Console.WriteLine("--------------------------------------------");

            // Let the moose speak!
            MooseSays("H I, I'M  E N T H U S I A S T I C !");
            MooseSays("Ask me a question!");


        }


        static bool Throw()
        {
            int PlayerScore;
            int PCScore;
            PrintHeader()
            int Playerthrow = Console.ReadLine();
            while (Playerthrow == 1 || Playerthrow == 2 || Playerthrow == 3)
            {
                int PCthrow = new Random().Next(1, 3);
                switch (Playerthrow)
                {
                    case 1:
                        Console.WriteLine("Case 1");
                        switch (PCthrow)
                        {
                            case 1:
                                Console.WriteLine("Case 1");
                                break;
                            case 2:
                                Console.WriteLine("Case 2");
                                break;
                            case 3:
                                Console.WriteLine("Case 3");
                                break;

                        }
                        break;
                    case 2:
                        Console.WriteLine("Case 2");
                        switch (PCthrow)
                        {
                            case 1:
                                Console.WriteLine("Case 1");
                                break;
                            case 2:
                                Console.WriteLine("Case 2");
                                break;
                            case 3:
                                Console.WriteLine("Case 3");
                                break;

                        }
                        break;
                    case 3:
                        Console.WriteLine("Case 3");
                        switch (PCthrow)
                        {
                            case 1:
                                Console.WriteLine("Case 1");
                                break;
                            case 2:
                                Console.WriteLine("Case 2");
                                break;
                            case 3:
                                Console.WriteLine("Case 3");
                                break;

                        }
                        break;
                }
                PrintHeader()
            int Playerthrow = Console.ReadLine();

            }
        }

        static void PrintHeader(int PlayerScore = 0, int PCScore = 0)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"| Player: {PlayerScore} | Computer: {PCScore}|");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("What would you like to throw?");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");

        }




        static void SoAsksTheMoose(List<string> question)
        {
            bool isTrue = MooseAsks(question[0]);
            string response = isTrue ? question[1] : question[2];
            MooseSays(response);
        }

        static void MooseSays(string message)
        {
            Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
        }

        static bool MooseAsks(string question)
        {
            Console.Write(" ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }
            return answer == "y";
        }

        static void Moose8Ball(List<string> answers)
        {
            Console.WriteLine("...well ...you heard the moose... ask a question");
            string answer = Console.ReadLine();
            while (answer != "")
            {
                int genRand = new Random().Next(1, answers.Count);
                Console.WriteLine(answers[genRand]);
                Console.WriteLine("go ahead ask another question");
                answer = Console.ReadLine();
            };

        }

    }
}