using System;

namespace About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //sequential method calls to run application
            WelcomeMessage();
            Question1();
            Question2();
            Question3Check(Question3());
            Question4Check(Question4());
            Question5();
            FarewellMessage();
        }

        //initializes global score counter
        static int ScoreCounter = 0;

        //prints welcome message and directions to console
        static void WelcomeMessage()
        {
            Console.WriteLine("Hello World! Welcome to this quiz.");
            Console.WriteLine("You will be asked 5 questions about me. Try to guess correctly!");
        }

        //asks the user whether or not they are ready to play with boolean return
        static bool Question1()
        {
            bool Ready = false;

            while (Ready == false)
            {
                Console.WriteLine("Are you ready? Type y/yes when ready.");
                string UserInput = (Console.ReadLine());

                if (UserInput.ToLower() == "yes" || UserInput.ToLower() == "y")
                {
                    Console.WriteLine("Congratulations! One down, four to go!");
                    Ready = true;
                }
            }

            ScoreCounter++;

            return true;
        }

        //asks user second question
        static void Question2()
        {
            Console.WriteLine("Next question!");
            Console.WriteLine("Semper Fi? Type y/yes or n/no.");
            string UserInput = Console.ReadLine();

            if (UserInput.ToLower() == "yes" || UserInput.ToLower() == "y")
            {
                Console.WriteLine("Oorah!");
                ScoreCounter++;
            } else if (UserInput.ToLower() == "no" || UserInput.ToLower() == "n")
            {
                Console.WriteLine("Meh.");
            }
        }

        //asks user third question, parses string to return an integer as a response, used in the question check below
        static int Question3()
        {
            Console.WriteLine("Next question!");
            Console.WriteLine("What is my favorite number?");
            string UserInput = Console.ReadLine();
            return int.Parse(UserInput);
        }

        //method using user answer from question 3 as argument
        static void Question3Check(int UserNumber)
        {
            if (UserNumber == 42)
            {
                Console.WriteLine("That is correct. Truly you understand life, love, and everything.");
                ScoreCounter++;
            } else
            {
                Console.WriteLine("Unfortunately that is incorrect. In another dimension, you just entered the nuclear launch codes.");
                Console.WriteLine("The correct answer was: 42");
            }
        }

        //asks user fourth question, returns typed response as a string
        static string Question4()
        {
            Console.WriteLine("Next question!");
            Console.WriteLine("Besides Oregon, name the first State I lived in. (Type your answer)");
            string UserInput = Console.ReadLine();

            return UserInput;
        }

        //method to check user's answer to question 4, accepting the previous string as an argument
        static void Question4Check(string UserAnswer)
        {
            if (UserAnswer.ToLower() == "liquid" || UserAnswer.ToLower() == "Liquid")
            {
                Console.WriteLine("Wow. Just...wow. Here's a point!");
                ScoreCounter++;
            } else
            {
                Console.WriteLine("Nice Try, the correct answer was: liquid");
            }
        }
        
        //asks user question 5, no return, evaluates string response
        static void Question5()
        {
            Console.WriteLine("Last question!");
            Console.WriteLine("Have I been to Syria?(type y/yes or n/no to answer.)");
            string UserInput = Console.ReadLine();

            if (UserInput.ToLower() == "y" || UserInput.ToLower() == "yes")
            {
                Console.WriteLine("Yes, I have been to Syria on accident. Long story.");
                ScoreCounter++;
            }
            else
            {
                Console.WriteLine("That is incorrect. I have been to Syria.");
            }
        }

        //farewell message to thank the user for playing and calculate final score
        static void FarewellMessage()
        {
            Console.Write("Thanks for playing!");
            Console.Write($"Your score is {ScoreCounter} out of 5. Press any key to exit.");
            Console.ReadLine();
        }
        
    }
}
