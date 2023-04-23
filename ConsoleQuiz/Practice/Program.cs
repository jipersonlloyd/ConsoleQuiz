using System;
using System.Threading.Tasks.Sources;

namespace Questionnaires {

    public class Practice
    {
        int wonmoney = 0;
        public static void Main(string[] args)
        {
            var flow = new Practice();
            flow.WelcomeScreen();
           
        }
        public void LastScreen() 
        {
            Console.WriteLine("You got all the correct answers. Thank you for participating :)");
            Console.WriteLine($"You Won : {wonmoney}");
            RepeatToStart();
        }
        public void WelcomeScreen()
        {
            wonmoney = wonmoney * 0;
            Console.WriteLine("Welcome to QuizLand Trivia");
            Console.Write("Press Enter Any Key to Continue: ");
            var anykey = Console.ReadLine();
            if (anykey == " ")
            {
            }
            else
            {
                LoadingScreen();
            }
        }
        public void LoadingScreen() 
        {
            Thread.Sleep(250);
            Console.Write("Loading Questionnaires. Please Wait");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            Console.Clear();
            Question1();
        }
        public void RepeatToStart() 
        {
            Console.Write("\n\nDo you want to play again ? [y] to play again [n] to exit : ");
            var playagain = Console.ReadLine();
            if (playagain == "y")
            {
                Console.Write("\nApp is Restarting");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(500);
                    Console.Write(".");
                }
            }
            else 
            {
                ExitScreen();
            }
            Console.Clear();
            WelcomeScreen();
        }
        public void ExitScreen() 
        {
            Thread.Sleep(500);
            Console.Write("App is Exiting ");
            for (int i = 0; i < 3; i++) 
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            Environment.Exit(0);
        }

        public void Question2() 
        {
            var points = 200;
            Console.WriteLine($"Money : {wonmoney}");
            Console.WriteLine("Alin sa mga sumusunod ang hindi sine-celebrate ng isang babae? ");
            Console.WriteLine("A: bridal shower                 B: debut ");
            Console.WriteLine("C: baby shower                   D: stag party");
            Console.Write("Answer : ");
            var choose = Console.ReadLine();
            if (choose == "c")
            {
                wonmoney = points;
                Console.WriteLine($"You Won : {points}");
                NextScreen();
                Question3();
            }
            else
            {
                Console.WriteLine("You choose the Wrong Answer. The correct answer is letter C. ");
                RepeatToStart();
            }
        }
        public void Question3()
        {
            var points = 500;
            Console.WriteLine($"Money : {wonmoney}");
            Console.WriteLine("Ano ang marka ang iniiwan ni Zorro? ");
            Console.WriteLine("A: bilog                        B: letrang Z ");
            Console.WriteLine("C: dollar sign                  D: drawing na espada");
            Console.Write("Answer : ");
            var choose = Console.ReadLine();
            if (choose == "b")
            {
                wonmoney = points;
                Console.WriteLine($"You Won : {points}");
                NextScreen();
                Question4();
            }
            else
            {
                Console.WriteLine("\n\nYou choose the Wrong Answer. The correct answer is letter B. ");
                RepeatToStart();
            }
        }
        public void Question4()
        {
            var points = 700;
            Console.WriteLine($"Money : {wonmoney}");
            Console.WriteLine(@"Ano sa French ang ""ThankYou""? ");
            Console.WriteLine("A: merci                         B: au revoir  ");
            Console.WriteLine("C: bonjour                       D: deja vu ");
            Console.Write("Answer : ");
            var choose = Console.ReadLine();
            if (choose == "a")
            {
                wonmoney = points;
                Console.WriteLine($"You Won : {points}");
                NextScreen();
                Question5();
            }
            else
            {
                Console.WriteLine("\n\nYou choose the Wrong Answer. The correct answer is letter A. ");
                RepeatToStart();
            }
        }
        public void Question5()
        {
            var points = 2000;
            Console.WriteLine($"Money : {wonmoney}");
            Console.WriteLine("Ano ang tawag sa mga estudyanteng nasa 4th year high school? ");
            Console.WriteLine("A: seniors                        B: sophomores ");
            Console.WriteLine("C: juniors                        D: freshmen");
            Console.Write("Answer : ");
            var choose = Console.ReadLine();
            if (choose == "a")
            {
                wonmoney = points;
                Console.WriteLine($"You Won : {points}");
                NextScreen();
                Question6();
            }
            else
            {
                Console.WriteLine("\n\nYou choose the Wrong Answer. The correct answer is letter A. ");
                RepeatToStart();
            }
        }
        public void Question6()
        {
            var points = 8000;
            Console.WriteLine($"Money : {wonmoney}");
            Console.WriteLine("Sa anong broadway musical ginamit ang mga kanta ng Abba? ");
            Console.WriteLine("A: Hairspray                         B: Les Miserables  ");
            Console.WriteLine("C: Mamma Mia!                        D: Miss Saigon ");
            Console.Write("Answer : ");
            var choose = Console.ReadLine();
            if (choose == "c")
            {
                wonmoney = points;
                Console.WriteLine($"You Won : {points}");
                NextScreen();
                Question7();
            }
            else
            {
                Console.WriteLine("\n\nYou choose the Wrong Answer. The correct answer is letter C. ");
                RepeatToStart();
            }
        }
        public void Question7()
        {
            var points = 32000;
            Console.WriteLine($"Money : {wonmoney}");
            Console.WriteLine("Mula sa top view, ano ang hugis ng precious stone na may emerald cut? ");
            Console.WriteLine("A: heart                         B: rectangle  ");
            Console.WriteLine("C: cicle                         D: oval");
            Console.Write("Answer : ");
            var choose = Console.ReadLine();
            if (choose == "b")
            {
                wonmoney = points;
                Console.WriteLine($"You Won : {points}");
                NextScreen();
                Question8();
            }
            else
            {
                Console.WriteLine("\n\nYou choose the Wrong Answer. The correct answer is letter B. ");
                RepeatToStart();
            }
        }
        public void Question8()
        {
            var points = 125000;
            Console.WriteLine($"Money : {wonmoney}");
            Console.WriteLine("Ano ang trabaho ng isang taong tinatawag na sensei? ");
            Console.WriteLine("A: singer                         B: chef  ");
            Console.WriteLine("C: magician                       D: teacher ");
            Console.Write("Answer : ");
            var choose = Console.ReadLine();
            if (choose == "d")
            {
                wonmoney = points;
                Console.WriteLine($"You Won : {points}");
                NextScreen();
                Question9();
            }
            else
            {
                Console.WriteLine("\n\nYou choose the Wrong Answer. The correct answer is letter D. ");
                RepeatToStart();
            }
        }
        public void Question9()
        {
            var points = 500000;
            Console.WriteLine($"Money : {wonmoney}");
            Console.WriteLine("Anong lugar ang tinatawag na Eternal City? ");
            Console.WriteLine("A: Rome                         B: Paris ");
            Console.WriteLine("C: Berlin                       D: Venice");
            Console.Write("Answer : ");
            var choose = Console.ReadLine();
            if (choose == "a")
            {
                wonmoney = points;
                Console.WriteLine($"You Won : {points}");
                NextScreen();
                Question10();
            }
            else
            {
                Console.WriteLine("\n\nYou choose the Wrong Answer. The correct answer is letter A. ");
                RepeatToStart();
            }
        }
        public void Question10()
        {
            var points = 1000000;
            Console.WriteLine($"Money : {wonmoney}");
            Console.WriteLine("Sa anong ilog ng China itinayo ang Three Gorges Dam? ");
            Console.WriteLine("A: Mekong River                        B: Yangtze River ");
            Console.WriteLine("C: Wusong River                        D: Ganges River ");
            Console.Write("Answer : ");
            var choose = Console.ReadLine();
            if (choose == "b")
            {
                wonmoney = points;
                Console.WriteLine($"You Won : {points}");
                NextScreen();
                LastScreen();
            }
            else
            {
                Console.WriteLine("\n\nYou choose the Wrong Answer. The correct answer is letter B. ");
                RepeatToStart();
            }
        }
        public void NextScreen() 
        {
            Console.Write("\n\nYou got the correct answer!, Proceeding to Next Question Please Wait ");
            for (int i = 0; i < 3; i++) 
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            Console.Clear();
        }
        public void Question1()
        {
            var points = 100;
            Console.WriteLine($"Money : {wonmoney}");
            Console.WriteLine("Aling Gamit ang may kadena ? ");
            Console.WriteLine("A: bisikleta                 B: silya ");
            Console.WriteLine("C: kutsilyo                  D: gripo");
            Console.Write("Answer : ");
            var choose = Console.ReadLine();
            if (choose == "a")
            {
                wonmoney = points;
                Console.WriteLine($"You Won : {points}");
                NextScreen();
                Question2();
            }
            else
            {
                Console.WriteLine("You choose the Wrong Answer. The correct answer is letter A. ");
                RepeatToStart();
            }
        }
    }
}