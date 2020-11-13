using System;
using System.Collections.Generic;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> answers = new List<string> {
            "As I see it, yes.",
            "Ask again later.",
            "Better not tell you now.",
            "Cannot predict now.",
            "Concentrate and ask again.",
            "Don’t count on it.",
            "It is certain.",
            "It is decidedly so.",
            "Most likely.",
            "My reply is no.",
            "My sources say no.",
            "Outlook not so good.",
            "Outlook good.",
            "Reply hazy, try again.",
            "Signs point to yes.",
            "Very doubtful.",
            "Without a doubt.",
            "Yes.",
            "Yes – definitely.",
            "You may rely on it.",
        };

            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");

            // Let the moose speak!
            MooseSays("H I, I'M  E N T H U S I A S T I C !");
            MooseSays("Ask me a question!");


            Moose8Ball(answers);

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