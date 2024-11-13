using System;

namespace ders
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

                        Console.Write("Enter gamer tag: ");
                        string gamertag = Console.ReadLine();

                        Console.Write("Enter level: ");
                        int level = int.Parse(Console.ReadLine());

                        char firstGamerTagCharacter = gamertag[0];

                        Console.WriteLine();
                        Console.WriteLine("");
            */
            //todo  --------------------------
            /*
                        Console.Write("In what month were you born?: ");
                        string month = Console.ReadLine();

                        Console.Write("On what day were you born?: ");
                        int day = int.Parse(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine($"Your birthday is {month} {day}");
                        Console.WriteLine("You will recive an email reminder on", month + (day - 1));

            */
            //todo  --------------------------
            /*
                        Console.Write("Input a number");
                        int a = int.Parse(Console.ReadLine());

                        if (a < 20)
                        {
                            Console.WriteLine("the number is less than 20");
                        }
                        else if (a == 20)
                        {
                            Console.WriteLine("the number is equal to 20");
                        }
                        else
                        {
                            Console.WriteLine("the number is not less than 20");
                        }

                        Console.WriteLine("value of number is: {0}", a);
                        Console.ReadLine();
            */
            //todo  --------------------------
            /*
                        Console.WriteLine("Input the mid term exam");
                        double mid = int.Parse(Console.ReadLine());

                        Console.WriteLine("Input the final exam");
                        double fin = int.Parse(Console.ReadLine());

                        double total = ((mid * 4 / 10) + (fin * 6 / 10));

                        Console.WriteLine("your total score is: {0}", total);

                        if (total >= 50)
                        {
                            Console.WriteLine("You pass");
                        }
                        else
                        {
                            Console.WriteLine("You failed");
                        }
            */
            //todo  --------------------------
            /*
                        Console.WriteLine("Input a number");
                        int num1 = int.Parse(Console.ReadLine());

                        if (num1 > 50)
                        {
                            Console.Write("Input the second number");
                            int num2 = int.Parse(Console.ReadLine());

                            if (num2 > 50)
                            {
                                Console.Write("The second number is higher than 50");
                            }
                            else if (num2 == 50)
                            {
                                Console.Write("The second number is equal than 50");
                            }
                            else
                            {
                                Console.Write("The second number is lower than 50");
                            }
                        }
                        else
                        {
                            Console.Write("The second number is lower than 50");
                        }
            */
            //todo  --------------------------
            /*
                        Console.Write("Pick up the shiny thing? (y, n): ");
                        char answer = Console.ReadLine()[0];

                        if (answer == 'y' || answer == 'Y')
                        {
                            Console.WriteLine("You have the shiny object");
                        }
                        else if (answer == 'n' || answer == 'N')
                        {
                            Console.WriteLine("You don't have the shiny object");
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                        Console.WriteLine();
            */
            //todo  --------------------------
            /*
                    startt:
                        Console.Write("Input a number: ");
                        int day = int.Parse(Console.ReadLine());

                        switch (day)
                        {
                            case 1:
                                Console.WriteLine("Monday");
                                break;

                            case 2:
                                Console.WriteLine("Tuesday");
                                break;

                            case 3:
                                Console.WriteLine("Wednesday");
                                break;

                            case 4:
                                Console.WriteLine("Thursday");
                                break;

                            case 5:
                                Console.WriteLine("Friday");
                                break;

                            case 6:
                                Console.WriteLine("Saturday");
                                break;

                            case 7:
                                Console.WriteLine("Sunday");
                                break;

                            default:
                                Console.WriteLine("Error");
                                break;
                        }
                        goto startt;
            */
            //todo  --------------------------
            /*
                    startt:
                        Console.Write("Do you enjoy c# ? (yes/no/maybe)");
                        string answer = Console.ReadLine();

                        switch (answer.ToLower())
                        {
                            case "yes":
                            case "maybe":
                                Console.WriteLine("Awesome");
                                break;

                            case "no":
                                Console.WriteLine("Too bad");
                                break;

                            default:
                                Console.WriteLine("Sorry, I dont't understand");
                                break;
                        }
                        goto startt;
            */
            //todo  --------------------------
            /*
                        Console.Write("Pick up the shiny thing? (y, n): ");
                        char answer = Console.ReadLine()[0];

                        switch (answer)
                        {
                            case 'y':
                            case 'Y':
                                Console.WriteLine("You have the shiny object");
                                break;

                            case 'n':
                            case 'N':
                                Console.WriteLine("You don't have the shiny object");
                                break;

                            default:
                                Console.WriteLine("error");
                                break;
                        }
            */
            //todo  --------------------------

            //!               FOR Statement

            /*
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(i);
                        }

                        Console.WriteLine();

                        for (int a = 10; a > 0; a--)
                        {
                            Console.Write(a);
                        }

                        Console.WriteLine();

                        for (char b = 'a'; b <= 'z'; b++)
                        {
                            Console.Write(b);
                        }

                        Console.WriteLine();

            */
            //todo  --------------------------
            /*

            //* for içinde for

            for (int c = 0; c < 10; c++)
            {
                for (int k = 0; k < 10; k++)
                {
                    Console.WriteLine("Value of i: {0}, k: {1}", c, k);
                }
            }

            */
            //todo  --------------------------
            /*   //* değerleri kendimiz giriyoruz
                    first:
                        int begin, end, step, total = 0;

                        Console.Write("Input the begining value: ");
                        begin = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Input the end value: ");
                        end = Convert.ToInt32(Console.ReadLine());
                        
                        Console.Write("Input the step value: ");
                        step = Convert.ToInt32(Console.ReadLine());

                        for (int i = begin; i <= end; i += step)
                        {
                            total = total + i;
                            Console.WriteLine(i);
                        }
                        Console.WriteLine(total);
                        Console.ReadLine();
                        Console.Clear();

                        goto first;

            */
            //todo  --------------------------

            //* girilen kelimelere göre

            /*
                        Console.Write("Input a word: ");
                        string word = Console.ReadLine();
                        int wordlength = word.Length;

                        for (int i = wordlength; i > 0; i--)
                        {
                            Console.Write(word.Substring(i - 1, 1));
                        }
                        Console.ReadLine();

            */
            //todo  --------------------------
            /*
                        string name;
                        Console.Write("Input a name: ");
                        name = Console.ReadLine();

                        //? 1 yerine 0 yazarsak yazdığımız ismin altında 2 tane boşluk olur. Olmaması için 1 yazdık
                        for (int i = 1; i <= name.Length; i++)
                        {
                            Console.WriteLine(name.Substring(0, i));
                        }
                        Console.ReadLine();

            */
            //todo  --------------------------
            //* belirlenen sayılar arasında rastgele sayı üret

            /*
                        

                        int Target;
                        Random RandomNumber = new Random();
                        Target = RandomNumber.Next(0, 5);
                        Console.WriteLine(Target);

            */
            //todo  --------------------------
            /*
                        int Target;
                        Random RandomNumber = new Random();
                        Target = RandomNumber.Next(0, 5);
                        Console.Write("Guess what number I am thinking of ...");

                        for (int Guess = 1; Guess <= 5; Guess++)
                        {
                            int Input = int.Parse(Console.ReadLine());

                            if (Input == Target)
                            {
                                Console.Write("Congrats, the number was" + Target);
                                break;
                            }
                            else
                            {
                                Console.Write("Try again");
                                Console.WriteLine("Press enter a new number.");
                            }
                        }
            */
            //todo  --------------------------

            //* Yönlendirmeli sayı tahmini

            /*
                        int rN;
                        int i = 0;
                        Random RandomNumber = new Random();
                        rN = RandomNumber.Next(50, 200);

                        for (i = 1; i <= 5; i++)
                        {
                            Console.WriteLine("Guess the number" + rN);
                            int guess = int.Parse(Console.ReadLine());
                            if (guess != rN)
                            {
                                if (guess > rN)
                                {
                                    Console.WriteLine("Daha küçük");
                                }
                                else
                                {
                                    Console.WriteLine("Daha büyük");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Congrats, you guessed at {0}. try", i);
                                Console.ReadKey();
                                break;
                            }

                            if (i > 5)
                            {
                                Console.WriteLine("You couldn't guess the number = " + rN);
                                Console.ReadLine();
                            }
                        }
            */
            //todo  --------------------------
            //!        Array 

            /*
                        string[] arr1 = new string[] { "one", "two", "three" };
                        string[] arr2 = { "digital", "game", "play" };
                        var arr3 = new string[] { "istanbul", "bilgi", "university" };

                        string[] arr4 = new string[3];
                        arr4[0] = "mario";
                        arr4[1] = "tank";
                        arr4[2] = "duck";

                        Console.WriteLine(arr1[0]);
                        Console.WriteLine(arr2[1]);
                        Console.WriteLine(arr3[2]);
                        Console.WriteLine(arr4[0]);

            */
            //todo  --------------------------
            /*
                        string[] book = new string[2];
                        book[0] = "Game";
                        book[1] = "Play";

                        for (int i = 0; i < book.Length; i++)
                        {
                            string name = book[i];
                            Console.WriteLine(name);
                        }

            */
            //todo  --------------------------
            /*
                        string[] animal = { "cat", "dog", "bird", "fish" };

                        int dogIndex = Array.IndexOf(animal, "dog");
                        Console.WriteLine(dogIndex);

                        int fishIndex = Array.IndexOf(animal, "fish");
                        Console.WriteLine(fishIndex);

            */
            //todo  --------------------------
            /*
                        string[] week = new string[7];

                        week[0] = "Sunday";
                        week[1] = "Monday";
                        week[2] = "Tuesday";
                        week[3] = "Wednesday";
                        week[4] = "Thursday";
                        week[5] = "Friday";
                        week[6] = "Saturday";

                        for (int i = 0; i < week.Length; i++)
                        {
                            Console.WriteLine(week[i]);
                        }

            */
            //todo  --------------------------
            /*
                        float sum = 0;
                        float average;

                        Console.WriteLine("Enter the size: ");
                        int size = int.Parse(Console.ReadLine());
                        int[] a = new int[size];

                        Console.WriteLine("Enter the elements of the array: ");

                        for (int i = 0; i < size; i++)
                        {
                            a[i] = int.Parse(Console.ReadLine());
                            sum = sum + a[i];
                        }

                        average = sum / size;

                        Console.WriteLine("Sum of array is: " + sum);
                        Console.WriteLine("Average of array is: " + average);
                        Console.ReadLine();

            */
            //todo  --------------------------
            /*
                        int a = 10;
                        while (a < 20)
                        {
                            Console.WriteLine("value of a: {0}", a);
                            a++;
                        }
                        Console.ReadLine();

            */
            //todo  --------------------------
            /*
                        Console.WriteLine("Input midterm");
                        float midterm = float.Parse(Console.ReadLine());

                        Console.WriteLine("Input final");
                        float final = float.Parse(Console.ReadLine());

                        float gradeNum = (midterm * 0.4f) + (final * 0.6f);

                        Console.WriteLine("Input numbers of students");
                        int studentNum = int.Parse(Console.ReadLine());

                        Console.Clear();

                        while (studentNum > 0)
                        {
                            if (gradeNum >= 50)
                            {
                                Console.WriteLine("{0} : Passed", studentNum);
                            }

                            else
                            {
                                Console.WriteLine("{0}: Failed", studentNum);
                            }
                            studentNum--;
                        }

            */
            //todo  --------------------------
            /*
                        Console.WriteLine("J - Jump");
                        Console.WriteLine("C - Crouch");
                        Console.WriteLine("Q - Quit");
                        Console.WriteLine();

                        Console.Write("Enter choice");
                        char choice = char.Parse(Console.ReadLine().ToUpper());
                        while (choice != 'J' &&
                        choice != 'C' &&
                        choice != 'Q')
                        {
                            //? print error message
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, must be J, C or Q");
                            Console.WriteLine();

                            //? print menu
                            Console.WriteLine("J - Jump");
                            Console.WriteLine("C - Crouch");
                            Console.WriteLine("Q - Quit");
                            Console.WriteLine();

                            //? prompt for and get menu choice
                            Console.Write("Enter choice: ");
                            choice = char.Parse(Console.ReadLine().ToUpper());
                        }

                        Console.WriteLine("You picked {0}", choice);

            */
        }
    }
}