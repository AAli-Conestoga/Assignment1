﻿internal class Program
{
     public static void Main(string[] args)
    {
        
        Console.WriteLine("Please choose a type of Pet");
        Console.WriteLine("1. Cat");
        Console.WriteLine("2. Dog");
        Console.WriteLine("3.Rabbit");
        int choice =int.Parse(Console.ReadLine());
        
        if (choice == 1)
        {
            Console.WriteLine("User Input: 1");
            Console.WriteLine("You've chosen a Cat.What would you like to name your pet?");
            string str =Console.ReadLine();
            Console.WriteLine("User Input :" + str);
            Console.WriteLine("Welcome, " + str + "! Let's take good care of him.");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Feed " + str);
            Console.WriteLine("2. Play with " + str);
            Console.WriteLine("3. Let " + str + " Rest");
            Console.WriteLine("4. Check " + str + "'s Status");
            Console.WriteLine("5. Exit");
            int choice1 =int.Parse(Console.ReadLine());
            if (choice1 == 4) 
            {
                Console.WriteLine("User Input: 4");
                Console.WriteLine(str + "'s Status:");
                Console.WriteLine("- Hunger: 5");
                Console.WriteLine("- Happiness: 5");
                Console.WriteLine("- Health : 8");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Feed " + str);
                Console.WriteLine("2. Play with " + str);
                Console.WriteLine("3. Let " + str + " Rest");
                Console.WriteLine("4. Check " + str + "'s Status");
                Console.WriteLine("5. Exit");
                int choice2 = int.Parse(Console.ReadLine());
                if (choice2 == 1) 
                {
                    Console.WriteLine("User input: 1");
                    Console.WriteLine("You fed " + str + ". His hunger decreases, and health improves slightly");
                    Console.WriteLine();
                    Console.WriteLine() ;
                    Console.WriteLine("Main Menu:");
                    Console.WriteLine("1. Feed " + str);
                    Console.WriteLine("2. Play with " + str);
                    Console.WriteLine("3. Let " + str + " Rest");
                    Console.WriteLine("4. Check " + str + "'s Status");
                    Console.WriteLine("5. Exit");
                    int choice3 = int.Parse(Console.ReadLine());
                    if (choice3 == 4) 
                    {
                        Console.WriteLine("User Input: 4");
                        Console.WriteLine(str + "'s Status:");
                        Console.WriteLine("- Hunger: 4");
                        Console.WriteLine("- Happiness: 5");
                        Console.WriteLine("- Health : 9");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Main Menu:");
                        Console.WriteLine("1. Feed " + str);
                        Console.WriteLine("2. Play with " + str);
                        Console.WriteLine("3. Let " + str + " Rest");
                        Console.WriteLine("4. Check " + str + "'s Status");
                        Console.WriteLine("5. Exit");
                        int choice4 = int.Parse(Console.ReadLine());
                        if (choice4 == 2) 
                        {
                            Console.WriteLine("User Input: 2");
                            Console.WriteLine("You played with " + str + ". His happiness increases,but he's a bit hungry.");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Main Menu:");
                            Console.WriteLine("1. Feed " + str);
                            Console.WriteLine("2. Play with " + str);
                            Console.WriteLine("3. Let " + str + " Rest");
                            Console.WriteLine("4. Check " + str + "'s Status");
                            Console.WriteLine("5. Exit");
                            int choice5= int.Parse(Console.ReadLine());
                            if (choice5 == 4) 
                            {
                                Console.WriteLine("User Input: 4");
                                Console.WriteLine(str + "'s Status:");
                                Console.WriteLine("- Hunger: 5");
                                Console.WriteLine("- Happiness: 7");
                                Console.WriteLine("- Health : 9");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Main Menu:");
                                Console.WriteLine("1. Feed " + str);
                                Console.WriteLine("2. Play with " + str);
                                Console.WriteLine("3. Let " + str + " Rest");
                                Console.WriteLine("4. Check " + str + "'s Status");
                                Console.WriteLine("5. Exit");
                                int choice6= int.Parse(Console.ReadLine());
                                if (choice6 == 5) 
                                
                                {
                                    Console.WriteLine("User Input: 5");
                                    Console.WriteLine("Thank you for playing with " + str + ". Goodbye!");


                                }

                            }


                        }

                    }

                }

            }

        
        
        }

    }
}