// Code and poor quality comments are by Space Core in 2021.
// Also some code is copied from stackoverflow lmfao.
// Please do not claim that you have made this.
using System;
using System.Threading;

namespace Gamethatyoucanusecommands
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declares all needed varibles.
            // There is a lot of varibles.
            string currentUserMessage;
            double userBalance = 0;
            string userBalanceDisplay = "Current balance: ";
            string helpCommand = "!help";
            string robCommand = "!rob";
            string farmJobCommand = "!farmjob";
            string farmJobUserAnswer;
            string farmJobQuestion1 = "Question 1: This is a fruit that is red, round, and big.\nAnswer must always be captilized properly.";
            string farmJobQuestion2 = "Question 2: This is an animal who's name is sometimes used to describe a person that doesn't want to do something because they are scared of it.";
            string farmJobQuestion3 = "Question 3: This something that all mammals produce and give their young.";
            string farmJobQuestion4 = "Question 4: This is what some animals are born from. We also use it for food and as an ingredient.";
            string balanceCommand = "!balance";
            string spellerTourmCommand = "!spelltourm";
            int wordsSpelledRight = 0;
            int correctFarmAnswers = 0;
            string allCommands = helpCommand + "\n" + robCommand + " - Note: This is pretty risky\n" + farmJobCommand + " - You take a shift at a farm. The highest you can get is 1K dollars.\n" + balanceCommand + " - Shows how much money you have.\n" + spellerTourmCommand + " - Spelling Tourmanent, prize is 3K";
            double robPayload;
            // Used for checking the current message made by the player faster.
            // Got sick of having to type all that.
            void CheckUserMessage()
            {
                currentUserMessage = (Console.ReadLine());
            }

            // Welcoming Message.
            Console.WriteLine("Welcome!\nThis is a game where you can use commands to do stuff.\nThe goal of the game is to reach 10K dollars.\nType \"!help\" for a list of commands.");

            // Makes the game happen while the player doesn't have 10K.
            while (userBalance != 10000)
            {
                // Generates all the stuff for robbing.
                // It would be better in the first else if but I'm to lazy to move it.
                Random rand = new();
                robPayload = rand.Next(-500, 500);
                currentUserMessage = (Console.ReadLine());
                if (currentUserMessage == helpCommand)
                {
                    Console.WriteLine(allCommands);
                } else if (currentUserMessage == robCommand)
                {
                    if (robPayload > 0)
                    {
                        Console.WriteLine("You are a lawbreaker and got away with it.\nYou have stolen " + robPayload + " dollars.");
                        userBalance += robPayload;
                        Console.WriteLine(userBalanceDisplay + userBalance);
                    } else if (robPayload < 0)
                    {
                        Console.WriteLine("You were caught. You were fined (number has - in it cause i don't know how to remove it): " + robPayload);
                        userBalance += robPayload;
                        Console.WriteLine(userBalanceDisplay + userBalance);
                    } else if (robPayload == 0)
                    {
                        Console.WriteLine("You got no money, weird\n" + userBalanceDisplay + userBalance);
                    } else
                    {
                        Console.WriteLine("You bugged out the game. Just how HOW!?!?!?!");
                    }
                /* 
                This is the Farm Job code.
                I literaly do not have the energy to comment this it took me around 5 hours to get it working.
                All you need to know is that it gives the questions and I had to code every single possible answer amount thats 4*4 for each answer so 16 for and answer then 16*4 since there are 4 questions.
                So thats 64 possible routes I had to code.
                And it all took 169(nice) lines.
                */
                } else if (currentUserMessage == farmJobCommand)
                {
                    Console.WriteLine("Welcome to the farm!\nYou'll just need to take a simple test and you will get your money.");
                    Console.WriteLine(farmJobQuestion1);
                    farmJobUserAnswer = (Console.ReadLine());
                    if (farmJobUserAnswer == "Apple")
                    {
                        correctFarmAnswers++;
                        Console.WriteLine("Correct!\n" + farmJobQuestion2);
                        farmJobUserAnswer = (Console.ReadLine());
                        if (farmJobUserAnswer == "Chicken")
                        {
                            correctFarmAnswers++;
                            Console.WriteLine("Correct!\n" + farmJobQuestion3);
                            farmJobUserAnswer = (Console.ReadLine());
                            if (farmJobUserAnswer == "Milk")
                            {
                                correctFarmAnswers++;
                                Console.WriteLine("Correct!\n" + farmJobQuestion4);
                                farmJobUserAnswer = (Console.ReadLine());
                                if (farmJobUserAnswer == "Egg")
                                {
                                    correctFarmAnswers++;
                                    Console.WriteLine("Correct Answer!\nThis is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                } else
                                {
                                    Console.WriteLine("Wrong Anwser.This is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                }
                            } else
                            {

                                Console.WriteLine("Wrong Answer.\n" + farmJobQuestion4);
                                farmJobUserAnswer = (Console.ReadLine());
                                if (farmJobUserAnswer == "Egg")
                                {
                                    correctFarmAnswers++;
                                    Console.WriteLine("This is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                } else
                                {
                                    Console.WriteLine("This is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                }
                            }
                        } else
                        {
                            Console.WriteLine("Wrong Answer.\n" + farmJobQuestion3);
                            farmJobUserAnswer = (Console.ReadLine());
                            if (farmJobUserAnswer == "Milk")
                            {
                                correctFarmAnswers++;
                                Console.WriteLine("Correct!\n" + farmJobQuestion4);
                                farmJobUserAnswer = (Console.ReadLine());
                                if (farmJobUserAnswer == "Egg")
                                {
                                    correctFarmAnswers++;
                                    Console.WriteLine("Correct Answer!\nThis is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                } else
                                {
                                    Console.WriteLine("Wrong Answer!\nThis is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                }
                            } else
                            {
                                Console.WriteLine("Wrong Answer.\n" + farmJobQuestion4);
                                farmJobUserAnswer = (Console.ReadLine());
                                if (farmJobUserAnswer == "Egg")
                                {
                                    correctFarmAnswers++;
                                    Console.WriteLine("Correct Answer!\nThis is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Wrong Answer!\nThis is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                }
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer.\n" + farmJobQuestion2);
                        farmJobUserAnswer = (Console.ReadLine());
                        if (farmJobUserAnswer == "Chicken")
                        {
                            correctFarmAnswers++;
                            Console.WriteLine("Correct!\n" + farmJobQuestion3);
                            farmJobUserAnswer = (Console.ReadLine());
                            if (farmJobUserAnswer == "Milk")
                            {
                                correctFarmAnswers++;
                                Console.WriteLine("Correct!\n" + farmJobQuestion4);
                                farmJobUserAnswer = (Console.ReadLine());
                                if (farmJobUserAnswer == "Egg")
                                {
                                    correctFarmAnswers++;
                                    Console.WriteLine("Correct Answer!\nThis is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Wrong Anwser.This is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                }
                            }
                            else
                            {

                                Console.WriteLine("Wrong Answer.\n" + farmJobQuestion4);
                                farmJobUserAnswer = (Console.ReadLine());
                                if (farmJobUserAnswer == "Egg")
                                {
                                    correctFarmAnswers++;
                                    Console.WriteLine("This is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("This is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong Answer.\n" + farmJobQuestion3);
                            farmJobUserAnswer = (Console.ReadLine());
                            if (farmJobUserAnswer == "Milk")
                            {
                                correctFarmAnswers++;
                                Console.WriteLine("Correct!\n" + farmJobQuestion4);
                                farmJobUserAnswer = (Console.ReadLine());
                                if (farmJobUserAnswer == "Egg")
                                {
                                    correctFarmAnswers++;
                                    Console.WriteLine("Correct Answer!\nThis is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Wrong Answer!\nThis is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong Answer.\n" + farmJobQuestion4);
                                farmJobUserAnswer = (Console.ReadLine());
                                if (farmJobUserAnswer == "Egg")
                                {
                                    correctFarmAnswers++;
                                    Console.WriteLine("Correct Answer!\nThis is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Wrong Answer!\nThis is the end of the test. You will be payed according to how much questions you got right.\nAmount of question answered correctly: " + correctFarmAnswers);
                                    Console.ReadLine();
                                }
                            }
                        }

                    }
                    if (correctFarmAnswers == 4)
                    {
                        userBalance += 1000;
                    }
                    else if (correctFarmAnswers == 3)
                    {
                        userBalance += 750;
                    }
                    else if (correctFarmAnswers == 2)
                    {
                        userBalance += 500;
                    }
                    else if (correctFarmAnswers == 1)
                    {
                        userBalance += 250;
                    }
                    else
                    {
                        Console.WriteLine("No money was earned.");
                    }
                    correctFarmAnswers = 0;
                    Console.WriteLine("Current Balance: " + userBalance);
                } else if (currentUserMessage == balanceCommand)
                {
                    Console.WriteLine(userBalanceDisplay + " " + userBalance);
                } 
                // Spelling Tourmanent.
                // This took 1 hour probably cause I figured out that I didn't have to code every single possible order of answering.
                else if (currentUserMessage == spellerTourmCommand)
                {
                    Console.WriteLine("You have entered the Spelling Tourmanent! All answers must be captilized.");
                    Console.WriteLine("Memorize this word: Democracy");
                    Thread.Sleep(2500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    RemoveCurrentConsoleLine();
                    currentUserMessage = (Console.ReadLine());
                    if (currentUserMessage == "Democracy") // I just noticed while coding this that if i just needed to use 8 if's and 4 else's in the farm job code. PAIN
                    {
                        wordsSpelledRight++;
                        Console.WriteLine("Correct!");
                    } else
                    {
                        Console.WriteLine("Wrong.");
                    }
                    Console.WriteLine("Memorize this word: Split");
                    Thread.Sleep(2500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    RemoveCurrentConsoleLine();
                    CheckUserMessage();
                    if (currentUserMessage == "Split")
                    {
                        wordsSpelledRight++;
                        Console.WriteLine("Correct!");
                    } else
                    {
                        Console.WriteLine("Wrong.");
                    }
                    Console.WriteLine("Memorize this word: Audacity");
                    Thread.Sleep(2500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    RemoveCurrentConsoleLine();
                    CheckUserMessage();
                    if (currentUserMessage == "Audacity")
                    {
                        wordsSpelledRight++;
                        Console.WriteLine("Correct!");
                    } else
                    {
                        Console.WriteLine("Wrong");
                    }
                    Console.WriteLine("Memorize this word: Hypocritical");
                    Thread.Sleep(2500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    RemoveCurrentConsoleLine();
                    CheckUserMessage();
                    if (currentUserMessage == "Hypocritical")
                    {
                        wordsSpelledRight++;
                        Console.WriteLine("Correct!");
                    } else
                    {
                        Console.WriteLine("Wrong.");
                    }
                    Console.WriteLine("Memorize this word: Blending");
                    Thread.Sleep(2500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    RemoveCurrentConsoleLine();
                    CheckUserMessage();
                    if (currentUserMessage == "Blending")
                    {
                        wordsSpelledRight++;
                        Console.WriteLine("Correct!");
                    } else
                    {
                        Console.WriteLine("Wrong.");
                    }
                    Console.WriteLine("Memorize this word: Project");
                    Thread.Sleep(2500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    RemoveCurrentConsoleLine();
                    CheckUserMessage();
                    if (currentUserMessage == "Project")
                    {
                        wordsSpelledRight++;
                        Console.WriteLine("Correct!");
                    } else
                    {
                        Console.WriteLine("Wrong.");
                    }
                    Console.WriteLine("This is the end of the Tourmanent.");
                    if (wordsSpelledRight == 6)
                    {
                        userBalance += 2000;
                        Console.WriteLine("You placed 1st place of 7 and won 2K");
                    } else if (wordsSpelledRight == 5)
                    {
                        userBalance += 1666;
                        Console.WriteLine("You placed 2nd place of 7 and won 1,666");
                    } else if (wordsSpelledRight == 4)
                    {
                        userBalance += 1333;
                        Console.WriteLine("You placed 3rd place of 7 and won 1,333");
                    } else if (wordsSpelledRight == 3)
                    {
                        userBalance += 1000;
                        Console.WriteLine("You placed 4th place of 7 and won 1K");
                    } else if (wordsSpelledRight == 2)
                    {
                        userBalance += 500;
                        Console.WriteLine("You placed 5th place of 7 and won 500");
                    } else if (wordsSpelledRight == 1)
                    {
                        userBalance += 250;
                        Console.WriteLine("You placed 6th place of 7 and won 250");
                    } else if (wordsSpelledRight == 0)
                    {
                        Console.WriteLine("You placed last place and won 250");
                    } else
                    {
                        Console.WriteLine("Something went wrong.");
                    }
                    Console.WriteLine(userBalanceDisplay + userBalance);
                } 
                else
                {
                    Console.WriteLine("Not a command.");
                }
            }
        }
        // Used for removing the most recent message in the console.
        public static void RemoveCurrentConsoleLine()
        {
            int currentCursorLine = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentCursorLine);
        }
        
    }

}
