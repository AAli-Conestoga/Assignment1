internal class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Please choose a type of Pet");
        Console.WriteLine("1. Cat");
        Console.WriteLine("2. Dog");
        Console.WriteLine("3.Rabbit");
        int choice = int.Parse(Console.ReadLine());
        int time = 0;


        if (choice == 1)
        {

            Console.WriteLine("User Input: 1");
            Console.WriteLine("You've chosen a Cat.What would you like to name your pet?");
            string str = Console.ReadLine();
            Console.WriteLine("User Input :" + str);
            Console.WriteLine("Welcome, " + str + "! Let's take good care of him.");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Feed " + str);
            Console.WriteLine("2. Play with " + str);
            Console.WriteLine("3. Let " + str + " Rest");
            Console.WriteLine("4. Check " + str + "'s Status");
            Console.WriteLine("5. Exit");
            int choice1 = int.Parse(Console.ReadLine());
            if (choice1 == 4)
            {
                Console.WriteLine("User Input: 4");
                Console.WriteLine(str + "'s Status:");
                Console.WriteLine("- Hunger: 5");
                Console.WriteLine("- Happiness: 5");
                Console.WriteLine("- Health : 5");
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
                    time++;
                    Console.WriteLine("User input: 1");
                    Console.WriteLine("You fed " + str + ". He is less hungry now, and health & Happiness improved slightly");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Time spent : " + time + " hours");
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
                        Console.WriteLine("- Hunger: 6");
                        Console.WriteLine("- Happiness: 6");
                        Console.WriteLine("- Health : 6");
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
                            time++;
                            Console.WriteLine("User Input: 2");
                            Console.WriteLine("You played with " + str + ". His happiness and health increases,but he's a bit hungry.");
                            Console.WriteLine();
                            Console.WriteLine("Total time now spend is :" + time + " hours");
                            Console.WriteLine();
                            Console.WriteLine("Main Menu:");
                            Console.WriteLine("1. Feed " + str);
                            Console.WriteLine("2. Play with " + str);
                            Console.WriteLine("3. Let " + str + " Rest");
                            Console.WriteLine("4. Check " + str + "'s Status");
                            Console.WriteLine("5. Exit");
                            int choice5 = int.Parse(Console.ReadLine());
                            if (choice5 == 4)
                            {
                                Console.WriteLine("User Input: 4");
                                Console.WriteLine(str + "'s Status:");
                                Console.WriteLine("- Hunger: 5");
                                Console.WriteLine("- Happiness: 7");
                                Console.WriteLine("- Health : 7");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Main Menu:");
                                Console.WriteLine("1. Feed " + str);
                                Console.WriteLine("2. Play with " + str);
                                Console.WriteLine("3. Let " + str + " Rest");
                                Console.WriteLine("4. Check " + str + "'s Status");
                                Console.WriteLine("5. Exit");
                                int choice6 = int.Parse(Console.ReadLine());
                                if (choice6 == 2)
                                {
                                    time++;
                                    Console.WriteLine("User Input: 2");
                                    Console.WriteLine("You played with " + str + ". His happiness increases,but he's a bit hungry.");
                                    Console.WriteLine();
                                    Console.WriteLine("Total time now spend is :" + time + " hours");
                                    Console.WriteLine();
                                    Console.WriteLine("Main Menu:");
                                    Console.WriteLine("1. Feed " + str);
                                    Console.WriteLine("2. Play with " + str);
                                    Console.WriteLine("3. Let " + str + " Rest");
                                    Console.WriteLine("4. Check " + str + "'s Status");
                                    Console.WriteLine("5. Exit");
                                    int choice7 = int.Parse(Console.ReadLine());
                                    if (choice7 == 4)
                                    {
                                        Console.WriteLine("User Input: 4");
                                        Console.WriteLine(str + "'s Status:");
                                        Console.WriteLine("- Hunger: 4");
                                        Console.WriteLine("- Happiness: 7");
                                        Console.WriteLine("- Health : 7");
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("Main Menu:");
                                        Console.WriteLine("1. Feed " + str);
                                        Console.WriteLine("2. Play with " + str);
                                        Console.WriteLine("3. Let " + str + " Rest");
                                        Console.WriteLine("4. Check " + str + "'s Status");
                                        Console.WriteLine("5. Exit");
                                        int choice8 = int.Parse(Console.ReadLine());
                                        if (choice8 == 2)
                                        {
                                            time++;
                                            Console.WriteLine("User Input: 2");
                                            Console.WriteLine("You played with " + str + ". His happiness increases,but he's a bit hungry.");
                                            Console.WriteLine();
                                            Console.WriteLine("Total time now spend is :" + time + " hours");
                                            Console.WriteLine();
                                            Console.WriteLine("Main Menu:");
                                            Console.WriteLine("1. Feed " + str);
                                            Console.WriteLine("2. Play with " + str);
                                            Console.WriteLine("3. Let " + str + " Rest");
                                            Console.WriteLine("4. Check " + str + "'s Status");
                                            Console.WriteLine("5. Exit");
                                            int choice9 = int.Parse(Console.ReadLine());
                                            if (choice9 == 4)
                                            {
                                                Console.WriteLine("User Input: 4");
                                                Console.WriteLine(str + "'s Status:");
                                                Console.WriteLine("- Hunger: 3");
                                                Console.WriteLine("- Happiness: 8");
                                                Console.WriteLine("- Health : 7");
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Console.WriteLine(str + " is very hungry and should be fed immediately");
                                                Console.WriteLine();
                                                Console.WriteLine("Main Menu:");
                                                Console.WriteLine("1. Feed " + str);
                                                Console.WriteLine("2. Play with " + str);
                                                Console.WriteLine("3. Let " + str + " Rest");
                                                Console.WriteLine("4. Check " + str + "'s Status");
                                                Console.WriteLine("5. Exit");
                                                int choice10 = int.Parse(Console.ReadLine());
                                                if (choice10 == 3)

                                                {
                                                    time++;
                                                    Console.WriteLine("User Input: 3");
                                                    Console.WriteLine(str + " is resting");
                                                    Console.WriteLine();
                                                    Console.WriteLine("Total time now spend is :" + time + " hours");
                                                    Console.WriteLine();
                                                    Console.WriteLine("Main Menu:");
                                                    Console.WriteLine("1. Feed " + str);
                                                    Console.WriteLine("2. Play with " + str);
                                                    Console.WriteLine("3. Let " + str + " Rest");
                                                    Console.WriteLine("4. Check " + str + "'s Status");
                                                    Console.WriteLine("5. Exit");
                                                    int choice11=int.Parse(Console.ReadLine());
                                                    if (choice11 == 4)
                                                    {
                                                            Console.WriteLine("User Input: 4");
                                                            Console.WriteLine(str + "'s Status:");
                                                            Console.WriteLine("- Hunger: 2");
                                                            Console.WriteLine("- Happiness: 7");
                                                            Console.WriteLine("- Health : 6");
                                                            Console.WriteLine();
                                                            Console.WriteLine("Main Menu:");
                                                            Console.WriteLine("1. Feed " + str);
                                                            Console.WriteLine("2. Play with " + str);
                                                            Console.WriteLine("3. Let " + str + " Rest");
                                                            Console.WriteLine("4. Check " + str + "'s Status");
                                                            Console.WriteLine("5. Exit");
                                                            int choice12 = int.Parse(Console.ReadLine());
                                                            if (choice12 == 2)
                                                            {

                                                                Console.WriteLine("User Input : 2");
                                                                Console.WriteLine(str + " refusing to play as he is too hungry and should be fed immediately");
                                                                int choice13 = int.Parse(Console.ReadLine());
                                                                if (choice13 == 4)
                                                                {
                                                                    Console.WriteLine("User Input: 4");
                                                                    Console.WriteLine(str + "'s Status:");
                                                                    Console.WriteLine("- Hunger: 3");
                                                                    Console.WriteLine("- Happiness: 8");
                                                                    Console.WriteLine("- Health : 7");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Main Menu:");
                                                                    Console.WriteLine("1. Feed " + str);
                                                                    Console.WriteLine("2. Play with " + str);
                                                                    Console.WriteLine("3. Let " + str + " Rest");
                                                                    Console.WriteLine("4. Check " + str + "'s Status");
                                                                    Console.WriteLine("5. Exit");

                                                                
                                                                int choice14 = int.Parse(Console.ReadLine());
                                                                if (choice14 == 5)
                                                                {

                                                                    Console.WriteLine("User Input: 5");
                                                                    Console.WriteLine("Thank you for playing and feeding " + str + ". Goodbye!");
                                                                }
                                                            }
                                                        }
                                                    }


                                                }

                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }

        }

        else if (choice == 2)

        {
            Console.WriteLine("User Input: 2");
            Console.WriteLine("You've chosen a Dog.What would you like to name your pet?");
            string str = Console.ReadLine();
            Console.WriteLine("User Input :" + str);
            Console.WriteLine("Welcome, " + str + "! Let's take good care of him.");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Feed " + str);
            Console.WriteLine("2. Play with " + str);
            Console.WriteLine("3. Let " + str + " Rest");
            Console.WriteLine("4. Check " + str + "'s Status");
            Console.WriteLine("5. Exit");
            int choice1 = int.Parse(Console.ReadLine());
            if (choice1 == 4)
            {
                Console.WriteLine("User Input: 4");
                Console.WriteLine(str + "'s Status:");
                Console.WriteLine("- Hunger: 5");
                Console.WriteLine("- Happiness: 5");
                Console.WriteLine("- Health : 5");
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
                    time++;
                    Console.WriteLine("User input: 1");
                    Console.WriteLine("You fed " + str + ". He is less hungry now, and health & Happiness improved slightly");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Time spent : " + time + " hours");
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
                        Console.WriteLine("- Hunger: 6");
                        Console.WriteLine("- Happiness: 6");
                        Console.WriteLine("- Health : 6");
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
                            time++;
                            Console.WriteLine("User Input: 2");
                            Console.WriteLine("You played with " + str + ". His happiness and health increases,but he's a bit hungry.");
                            Console.WriteLine();
                            Console.WriteLine("Total time now spend is :" + time + " hours");
                            Console.WriteLine();
                            Console.WriteLine("Main Menu:");
                            Console.WriteLine("1. Feed " + str);
                            Console.WriteLine("2. Play with " + str);
                            Console.WriteLine("3. Let " + str + " Rest");
                            Console.WriteLine("4. Check " + str + "'s Status");
                            Console.WriteLine("5. Exit");
                            int choice5 = int.Parse(Console.ReadLine());
                            if (choice5 == 4)
                            {
                                Console.WriteLine("User Input: 4");
                                Console.WriteLine(str + "'s Status:");
                                Console.WriteLine("- Hunger: 5");
                                Console.WriteLine("- Happiness: 7");
                                Console.WriteLine("- Health : 7");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Main Menu:");
                                Console.WriteLine("1. Feed " + str);
                                Console.WriteLine("2. Play with " + str);
                                Console.WriteLine("3. Let " + str + " Rest");
                                Console.WriteLine("4. Check " + str + "'s Status");
                                Console.WriteLine("5. Exit");
                                int choice6 = int.Parse(Console.ReadLine());
                                if (choice6 == 2)
                                {
                                    time++;
                                    Console.WriteLine("User Input: 2");
                                    Console.WriteLine("You played with " + str + ". His happiness increases,but he's a bit hungry.");
                                    Console.WriteLine();
                                    Console.WriteLine("Total time now spend is :" + time + " hours");
                                    Console.WriteLine();
                                    Console.WriteLine("Main Menu:");
                                    Console.WriteLine("1. Feed " + str);
                                    Console.WriteLine("2. Play with " + str);
                                    Console.WriteLine("3. Let " + str + " Rest");
                                    Console.WriteLine("4. Check " + str + "'s Status");
                                    Console.WriteLine("5. Exit");
                                    int choice7 = int.Parse(Console.ReadLine());
                                    if (choice7 == 4)
                                    {
                                        Console.WriteLine("User Input: 4");
                                        Console.WriteLine(str + "'s Status:");
                                        Console.WriteLine("- Hunger: 4");
                                        Console.WriteLine("- Happiness: 7");
                                        Console.WriteLine("- Health : 7");
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("Main Menu:");
                                        Console.WriteLine("1. Feed " + str);
                                        Console.WriteLine("2. Play with " + str);
                                        Console.WriteLine("3. Let " + str + " Rest");
                                        Console.WriteLine("4. Check " + str + "'s Status");
                                        Console.WriteLine("5. Exit");
                                        int choice8 = int.Parse(Console.ReadLine());
                                        if (choice8 == 2)
                                        {
                                            time++;
                                            Console.WriteLine("User Input: 2");
                                            Console.WriteLine("You played with " + str + ". His happiness increases,but he's a bit hungry.");
                                            Console.WriteLine();
                                            Console.WriteLine("Total time now spend is :" + time + " hours");
                                            Console.WriteLine();
                                            Console.WriteLine("Main Menu:");
                                            Console.WriteLine("1. Feed " + str);
                                            Console.WriteLine("2. Play with " + str);
                                            Console.WriteLine("3. Let " + str + " Rest");
                                            Console.WriteLine("4. Check " + str + "'s Status");
                                            Console.WriteLine("5. Exit");
                                            int choice9 = int.Parse(Console.ReadLine());
                                            if (choice9 == 4)
                                            {
                                                Console.WriteLine("User Input: 4");
                                                Console.WriteLine(str + "'s Status:");
                                                Console.WriteLine("- Hunger: 3");
                                                Console.WriteLine("- Happiness: 8");
                                                Console.WriteLine("- Health : 7");
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Console.WriteLine(str + " is very hungry and should be fed immediately");
                                                Console.WriteLine();
                                                Console.WriteLine("Main Menu:");
                                                Console.WriteLine("1. Feed " + str);
                                                Console.WriteLine("2. Play with " + str);
                                                Console.WriteLine("3. Let " + str + " Rest");
                                                Console.WriteLine("4. Check " + str + "'s Status");
                                                Console.WriteLine("5. Exit");
                                                int choice10 = int.Parse(Console.ReadLine());
                                                if (choice10 == 3)

                                                {
                                                    time++;
                                                    Console.WriteLine("User Input: 3");
                                                    Console.WriteLine(str + " is resting");
                                                    Console.WriteLine();
                                                    Console.WriteLine("Total time now spend is :" + time + " hours");
                                                    Console.WriteLine();
                                                    Console.WriteLine("Main Menu:");
                                                    Console.WriteLine("1. Feed " + str);
                                                    Console.WriteLine("2. Play with " + str);
                                                    Console.WriteLine("3. Let " + str + " Rest");
                                                    Console.WriteLine("4. Check " + str + "'s Status");
                                                    Console.WriteLine("5. Exit");
                                                    int choice11 = int.Parse(Console.ReadLine());
                                                    if (choice11 == 4)
                                                    {
                                                            Console.WriteLine("User Input: 4");
                                                            Console.WriteLine(str + "'s Status:");
                                                            Console.WriteLine("- Hunger: 2");
                                                            Console.WriteLine("- Happiness: 7");
                                                            Console.WriteLine("- Health : 6");
                                                            Console.WriteLine();
                                                            Console.WriteLine("Main Menu:");
                                                            Console.WriteLine("1. Feed " + str);
                                                            Console.WriteLine("2. Play with " + str);
                                                            Console.WriteLine("3. Let " + str + " Rest");
                                                            Console.WriteLine("4. Check " + str + "'s Status");
                                                            Console.WriteLine("5. Exit");
                                                            int choice12 = int.Parse(Console.ReadLine());
                                                            if (choice12 == 2)
                                                            {

                                                                Console.WriteLine("User Input : 2");
                                                                Console.WriteLine(str + " refusing to play as he is too hungry and should be fed immediately");
                                                                int choice13 = int.Parse(Console.ReadLine());
                                                                if (choice13 == 4)
                                                                {
                                                                    Console.WriteLine("User Input: 4");
                                                                    Console.WriteLine(str + "'s Status:");
                                                                    Console.WriteLine("- Hunger: 3");
                                                                    Console.WriteLine("- Happiness: 8");
                                                                    Console.WriteLine("- Health : 7");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Main Menu:");
                                                                    Console.WriteLine("1. Feed " + str);
                                                                    Console.WriteLine("2. Play with " + str);
                                                                    Console.WriteLine("3. Let " + str + " Rest");
                                                                    Console.WriteLine("4. Check " + str + "'s Status");
                                                                    Console.WriteLine("5. Exit");

                                                                
                                                                int choice14 = int.Parse(Console.ReadLine());
                                                                if (choice14 == 5)
                                                                {

                                                                    Console.WriteLine("User Input: 5");
                                                                    Console.WriteLine("Thank you for playing and feeding " + str + ". Goodbye!");
                                                                }
                                                            }
                                                        }
                                                    }
                                                }



                                                            }
                                        }
                                    }
                                }
                            }


                        }

                    }

                }

            }



        }
        else if (choice == 3)
        {
            Console.WriteLine("User Input: 3");
            Console.WriteLine("You've chosen a Rabbit.What would you like to name your pet?");
            string str = Console.ReadLine();
            Console.WriteLine("User Input :" + str);
            Console.WriteLine("Welcome, " + str + "! Let's take good care of him.");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Feed " + str);
            Console.WriteLine("2. Play with " + str);
            Console.WriteLine("3. Let " + str + " Rest");
            Console.WriteLine("4. Check " + str + "'s Status");
            Console.WriteLine("5. Exit");
            int choice1 = int.Parse(Console.ReadLine());
            if (choice1 == 4)
            {
                Console.WriteLine("User Input: 4");
                Console.WriteLine(str + "'s Status:");
                Console.WriteLine("- Hunger: 5");
                Console.WriteLine("- Happiness: 5");
                Console.WriteLine("- Health : 5");
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
                    time++;
                    Console.WriteLine("User input: 1");
                    Console.WriteLine("You fed " + str + ". He is less hungry now, and health & Happiness improved slightly");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Time spent : " + time + " hours");
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
                        Console.WriteLine("- Hunger: 6");
                        Console.WriteLine("- Happiness: 6");
                        Console.WriteLine("- Health : 6");
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
                            time++;
                            Console.WriteLine("User Input: 2");
                            Console.WriteLine("You played with " + str + ". His happiness and health increases,but he's a bit hungry.");
                            Console.WriteLine();
                            Console.WriteLine("Total time now spend is :" + time + " hours");
                            Console.WriteLine();
                            Console.WriteLine("Main Menu:");
                            Console.WriteLine("1. Feed " + str);
                            Console.WriteLine("2. Play with " + str);
                            Console.WriteLine("3. Let " + str + " Rest");
                            Console.WriteLine("4. Check " + str + "'s Status");
                            Console.WriteLine("5. Exit");
                            int choice5 = int.Parse(Console.ReadLine());
                            if (choice5 == 4)
                            {
                                Console.WriteLine("User Input: 4");
                                Console.WriteLine(str + "'s Status:");
                                Console.WriteLine("- Hunger: 5");
                                Console.WriteLine("- Happiness: 7");
                                Console.WriteLine("- Health : 7");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Main Menu:");
                                Console.WriteLine("1. Feed " + str);
                                Console.WriteLine("2. Play with " + str);
                                Console.WriteLine("3. Let " + str + " Rest");
                                Console.WriteLine("4. Check " + str + "'s Status");
                                Console.WriteLine("5. Exit");
                                int choice6 = int.Parse(Console.ReadLine());
                                if (choice6 == 2)
                                {
                                    time++;
                                    Console.WriteLine("User Input: 2");
                                    Console.WriteLine("You played with " + str + ". His happiness increases,but he's a bit hungry.");
                                    Console.WriteLine();
                                    Console.WriteLine("Total time now spend is :" + time + " hours");
                                    Console.WriteLine();
                                    Console.WriteLine("Main Menu:");
                                    Console.WriteLine("1. Feed " + str);
                                    Console.WriteLine("2. Play with " + str);
                                    Console.WriteLine("3. Let " + str + " Rest");
                                    Console.WriteLine("4. Check " + str + "'s Status");
                                    Console.WriteLine("5. Exit");
                                    int choice7 = int.Parse(Console.ReadLine());
                                    if (choice7 == 4)
                                    {
                                        Console.WriteLine("User Input: 4");
                                        Console.WriteLine(str + "'s Status:");
                                        Console.WriteLine("- Hunger: 4");
                                        Console.WriteLine("- Happiness: 7");
                                        Console.WriteLine("- Health : 7");
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("Main Menu:");
                                        Console.WriteLine("1. Feed " + str);
                                        Console.WriteLine("2. Play with " + str);
                                        Console.WriteLine("3. Let " + str + " Rest");
                                        Console.WriteLine("4. Check " + str + "'s Status");
                                        Console.WriteLine("5. Exit");
                                        int choice8 = int.Parse(Console.ReadLine());
                                        if (choice8 == 2)
                                        {
                                            time++;
                                            Console.WriteLine("User Input: 2");
                                            Console.WriteLine("You played with " + str + ". His happiness increases,but he's a bit hungry.");
                                            Console.WriteLine();
                                            Console.WriteLine("Total time now spend is :" + time + " hours");
                                            Console.WriteLine();
                                            Console.WriteLine("Main Menu:");
                                            Console.WriteLine("1. Feed " + str);
                                            Console.WriteLine("2. Play with " + str);
                                            Console.WriteLine("3. Let " + str + " Rest");
                                            Console.WriteLine("4. Check " + str + "'s Status");
                                            Console.WriteLine("5. Exit");
                                            int choice9 = int.Parse(Console.ReadLine());
                                            if (choice9 == 4)
                                            {
                                                Console.WriteLine("User Input: 4");
                                                Console.WriteLine(str + "'s Status:");
                                                Console.WriteLine("- Hunger: 3");
                                                Console.WriteLine("- Happiness: 8");
                                                Console.WriteLine("- Health : 7");
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Console.WriteLine(str + " is very hungry and should be fed immediately");
                                                Console.WriteLine();
                                                Console.WriteLine("Main Menu:");
                                                Console.WriteLine("1. Feed " + str);
                                                Console.WriteLine("2. Play with " + str);
                                                Console.WriteLine("3. Let " + str + " Rest");
                                                Console.WriteLine("4. Check " + str + "'s Status");
                                                Console.WriteLine("5. Exit");
                                                int choice10 = int.Parse(Console.ReadLine());
                                                if (choice10 == 3)

                                                {
                                                    time++;
                                                    Console.WriteLine("User Input: 3");
                                                    Console.WriteLine(str + " is resting");
                                                    Console.WriteLine();
                                                    Console.WriteLine("Total time now spend is :" + time + " hours");
                                                    Console.WriteLine();
                                                    Console.WriteLine("Main Menu:");
                                                    Console.WriteLine("1. Feed " + str);
                                                    Console.WriteLine("2. Play with " + str);
                                                    Console.WriteLine("3. Let " + str + " Rest");
                                                    Console.WriteLine("4. Check " + str + "'s Status");
                                                    Console.WriteLine("5. Exit");
                                                    int choice11 = int.Parse(Console.ReadLine());
                                                    if (choice11 == 4)
                                                    {
                                                            Console.WriteLine("User Input: 4");
                                                            Console.WriteLine(str + "'s Status:");
                                                            Console.WriteLine("- Hunger: 2");
                                                            Console.WriteLine("- Happiness: 7");
                                                            Console.WriteLine("- Health : 6");
                                                            Console.WriteLine();
                                                            Console.WriteLine("Main Menu:");
                                                            Console.WriteLine("1. Feed " + str);
                                                            Console.WriteLine("2. Play with " + str);
                                                            Console.WriteLine("3. Let " + str + " Rest");
                                                            Console.WriteLine("4. Check " + str + "'s Status");
                                                            Console.WriteLine("5. Exit");
                                                            int choice12 = int.Parse(Console.ReadLine());
                                                            if (choice12 == 2)
                                                            {

                                                                Console.WriteLine("User Input : 2");
                                                                Console.WriteLine(str + " refusing to play as he is too hungry and should be fed immediately");
                                                                int choice13 = int.Parse(Console.ReadLine());
                                                                if (choice13 == 4)
                                                                {
                                                                    Console.WriteLine("User Input: 4");
                                                                    Console.WriteLine(str + "'s Status:");
                                                                    Console.WriteLine("- Hunger: 3");
                                                                    Console.WriteLine("- Happiness: 8");
                                                                    Console.WriteLine("- Health : 7");
                                                                    Console.WriteLine();
                                                                    Console.WriteLine("Main Menu:");
                                                                    Console.WriteLine("1. Feed " + str);
                                                                    Console.WriteLine("2. Play with " + str);
                                                                    Console.WriteLine("3. Let " + str + " Rest");
                                                                    Console.WriteLine("4. Check " + str + "'s Status");
                                                                    Console.WriteLine("5. Exit");

                                                                
                                                                int choice14 = int.Parse(Console.ReadLine());
                                                                if (choice14 == 5)
                                                                {

                                                                    Console.WriteLine("User Input: 5");
                                                                    Console.WriteLine("Thank you for playing and feeding " + str + ". Goodbye!");
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                       



                                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}










