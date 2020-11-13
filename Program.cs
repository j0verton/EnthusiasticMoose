using System;
using System.Collections.Generic;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> CanadaQuestion = new List<string>()
        {
            "Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!"
        };

            List<string> EnthusiasticQuestion = new List<string>()
        {
            "Are you enthusiastic?", "Yay!", "You should try it!"
        };

            List<string> LoveCSharpQuestion = new List<string>()
        {
            "Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will..."
        };
            List<string> SecretQuestion = new List<string>()
        {
            "Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!"
        };
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");

            // Let the moose speak!
            MooseSays("H I, I'M  E N T H U S I A S T I C !");
            MooseSays("I really am enthusiastic");


            // Ask a question
            SoAsksTheMoose(CanadaQuestion);
            SoAsksTheMoose(EnthusiasticQuestion);
            SoAsksTheMoose(LoveCSharpQuestion);
            SoAsksTheMoose(SecretQuestion);
        }



        static void SoAsksTheMoose(List<string> question)
        {

            bool isTrue = MooseAsks(question[0]);
            if (isTrue)
            {
                MooseSays(question[1]);
            }
            else
            {
                MooseSays(question[2]);
            }
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
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            return answer == "y";
        }

    }
}