// Code is by Space Core in 2021.
// Please do not claim that you have made this.
using System;

namespace Gamethatyoucanusecommands
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declares all needed varibles.
            // There is alot of varibles.
            string currentUserMessage = null;
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
            int correctFarmAnswers = 0;
            string allCommands = helpCommand + "\n" + robCommand + " - Note: This is pretty risky\n" + farmJobCommand + " - You take a shift at a farm. The highest you can get is 1K dollars.\n" + balanceCommand + " - Shows how much money you have.";
            double robPayload;

            // Welcoming Message.
            Console.WriteLine("Welcome!\nThis is a game where you can use commands to do stuff.\nThe goal of the game is to reach 10K dollars.\nType \"!help\" for a list of commands.");

            // Makes the game happen while the player doesn't have 10K.
            while (userBalance != 10000)
            {
                Random rand = new Random();
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
                    Console.WriteLine("Current Balance: " + userBalance);
                } else if (currentUserMessage == balanceCommand)
                {
                    Console.WriteLine(userBalanceDisplay + " " + userBalance);
                }
            }
        }
    }

}
