using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace CCP
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ================ C# Revision ===================== */

            //writeline
            Console.WriteLine("First Line");

            //readline
            Console.ReadLine();

            //variables
            //int
            int age = 20;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);


            //long
            long num1 = 3404004;
            Console.WriteLine(num1);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            //double
            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            //float 
            float precision = 5.0001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            //decimal
            decimal money = 14.99M;
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            //string 
            string name = "Nour";
            char letter = 'N';
            Console.WriteLine("Your name is " + name + letter);

            //declare variables
            int x = 10, y = 20, z = 30;
            Console.Write(z + y + x);

            //convert to int
            string textAge = "23";
            int a = Convert.ToInt32(textAge);
            Console.WriteLine(a);

            //convert to int64
            string textBigNumber = "-900000000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            //convert to double
            string textNumber = "-55.43";
            double doubleNumber = Convert.ToDouble(textNumber);
            Console.WriteLine(doubleNumber);

            //convert to precision
            string textPrecision = "5.00001";
            float numPrecision = Convert.ToSingle(textPrecision);
            Console.WriteLine(numPrecision);

            //convert to Decimal
            string textMoney = "14.99";
            decimal decMoney = Convert.ToDecimal(textMoney);
            Console.WriteLine(decMoney);


            /* ====================== Boolean datatypes ================================ */

            bool value = true;
            bool isMale = false;
            Console.WriteLine(value);

            //increment and decrement

            int age2 = 23;

            age2++;
            age2 = age2 + 1;
            age2 += 1;
            Console.WriteLine(age2);

            age2--;
            age2 -= 1;
            age2 *= 3;
            age2 /= 2;
            Console.WriteLine(age2);

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch); //unicode value

            //remindar
            int firstNum = 10;
            int secondNum = 2;

            Console.WriteLine(firstNum / secondNum);
            Console.WriteLine(firstNum % secondNum);

            //print age
            Console.Write("Enter your age");
            string ag = Console.ReadLine();
            Console.WriteLine("your age is" + ag);

            //condition statement
            int age3 = 19;
            if (age3 >= 18 && age <= 25)
            {
                Console.WriteLine("you are between 18 and 25");
            }
            else if (age >= 25)
            {
                Console.WriteLine("your are 25 or older");
            }
            else if (age3 < 0 || age > 150)
            {
                Console.WriteLine("Invalid age");
            }
            else
            {
                Console.WriteLine("your age is > 25");
            }

            //check the real number

            Console.Write("Enter the first number");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("Enter the second number");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.Write("what is the value of" + numberA + " x " + numberB + "?");
            Console.WriteLine();

            while (answer != actualAnswer)
            {
                Console.Write("Enter your answer:");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (answer != actualAnswer)
                {

                    Console.WriteLine("close but it is wrong!");
                }

            }


            Console.WriteLine("well done");
            Console.ReadLine();




            // Do while loop

            do {
                Console.Write("Enter your answer:");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (answer != actualAnswer)
                {

                    Console.WriteLine("close but it is wrong!");
                    Console.WriteLine();
                }
            } while (answer != actualAnswer);



            //if statement 
            Console.Write("Enter a day of the week");
            int day = Convert.ToInt32(Console.ReadLine());
            if (day == 1)
            {
                Console.WriteLine("Sun");
            }
            else if (day == 2)
            {
                Console.WriteLine("Mon");
            }
            else if (day == 3)
            {
                Console.WriteLine("Tue");
            }
            else if (day == 4)
            {
                Console.WriteLine("Wed");
            }
            else if (day == 5)
            {
                Console.WriteLine("Th");
            }
            else if (day == 6)
            {
                Console.WriteLine("Fri");
            }
            else if (day == 7)
            {
                Console.WriteLine("Sa");
            }
            else
            {
                Console.WriteLine("invalid number")
            }


            //switch statement

            switch (day)
            {
                case 1: Console.WriteLine("Sun");
                    break;
                case 2:
                    Console.WriteLine("Mo");
                    break;
                case 3:
                    Console.WriteLine("Tu");
                    break;
                case 4:
                    Console.WriteLine("Wed");
                    break;
                case 5:
                    Console.WriteLine("Th");
                    break;
                case 6:
                    Console.WriteLine("Fri");
                    break;
                case 7:
                    Console.WriteLine("Sa");
                    break;
                default: Console.WriteLine("enter Invalid number");
                    break;

            }

            //for loop + if 

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            // for
            Console.Write("What do you want to repeat?");
            string message = Console.ReadLine();


            Console.Write("How many times do you want to say Hi?");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.Write("sorry, please enter a valid number");
            }
            else
            {
                for (int i = 0; i <= loopCounter; i++)
                {
                    Console.WriteLine(message);
                }
            }


            //condition ? true : false
            int n = 0;
            string result = n >= 0 ? "Valid" : "Invalid";
            Console.WriteLine(result);

            //another way

            Console.WriteLine(n >= 0 ? "valid" : "Invalid");


            // Double format
            double val = 1000D / 12.34D;

            Console.WriteLine(val);
            Console.WriteLine(string.Format("{0} {1}", val, 1000));
            Console.WriteLine(string.Format("{0:0}", val));
            Console.WriteLine(string.Format("{0:0.0}", val));
            Console.WriteLine(string.Format("{0:0.00}", val));



            //for currencies 

            double m = 10D / 3D; //3.3333333333

            Console.WriteLine(m.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(m.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(m.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));



            //
            bool success = true;

            while (success)
            {
                Console.Write("Enter a number:");

                string numInput = Console.ReadLine();

                // int num = Convert.ToInt32(numInput);

                // Console.WriteLine(num);



                if (int.TryParse(numInput, out int num))
                {
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to convert!");
                }

            }

            /** ask the user for a number for the table
                write a for loop to print x times table **/

            Console.Write("Enter a number");

            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 0; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
            }

            /* 
             * create a loop from 1 to x (15)
             * 3 and 5 = FizzBuzz
             * 3 = Fizz
             * 5 = Buzz
             * else = number
             * 
             */

            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }



            /* another way */

            bool threeDiv = false;
            bool fiveDiv = false;

            for (int i = 1; i <= 15; i++)
            {

                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;


                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }


            // backslash \t \n \" \\
            string speech = "He said \"something\"";
            string path = "C:\\Users\\CoffeeNCode\\Desktop\\C# Course\n";
            Console.WriteLine(path);
            Console.WriteLine(speech);


            //Formating

            string na = "Nour";
            int g = 20;
            Console.WriteLine("Name:" + na + "\nage" + g);

            //another way

            Console.WriteLine($"your name is {0}, and your age is {1}", name, age);

            //another way

            string test = string.Concat("your name is", name, "and your age is", age);
            Console.WriteLine(test);

            //array

            string[] names = new string[] { "Aba", "test", "Test" };

            Console.WriteLine(string.Concat(names));

            //empty string

            //    string name11 = string.Empty;

            Console.WriteLine("Enter your name");

            string name22 = Console.ReadLine();

            Console.WriteLine($"your name is{name22}");


            //comparison

            string msg = "Hello";
            string comp = "Hi";

            if (msg == comp)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Diff");
            }

            //another way

            if (msg.Equals(comp))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Diff");
            }

            //! not equal
            if (!name.Equals(""))
            {
                Console.WriteLine("your name is" + name);
            }

            // another ! not equal
            if (name != "")
            {
                Console.WriteLine("your name is " + name)
            }

            // array

            char[] chars = new char[] { 'a', 'b', 'c' };

            object newCompare = new string(chars);

            if (message.Equals(newCompare))

                Console.WriteLine("same");

            else

                Console.WriteLine("Different");


            // print char

            string msg1 = "Hello, Nour";

            for (int i = 0; i < msg1.Length; i++)
            {
                Console.WriteLine(msg1[i]);
                Thread.Sleep(250); // 1000ms = 1sec - animation while typing
            }

            Console.WriteLine(message.Contains("C"));


            bool contains = false;


            for (int i = 0; i < msg1.Length; i++)
            {
                if (msg1[i].Equals('C'))
                {
                    contains = true;
                }
                else
                {
                    contains = false;
                }

            }

            Console.WriteLine(contains);

            // if(string.IsNullOrEmpty(name))
            //   Console.writeLine("2");

            // string length

            Console.WriteLine("Enter your message");

            string message1 = Console.ReadLine();

            Console.WriteLine(message1[0]);

            Console.WriteLine(message1.Length);


            for (int i = 0; i < message1.Length; i++) // 0-13
            {
                Console.Write(message1[i]);
            }

            Console.WriteLine("-");

            for (int j = message1.Length - 1; j >= 0; j--) //13-0
            {
                Console.WriteLine(message1[j]);
            }



            //check password

            Console.Write("Enter password");
            string password = Console.ReadLine();

            Console.Write("Enter password again");
            string passwordC = Console.ReadLine();

            if (!password.Equals(string.Empty))
            {
                if (!passwordC.Equals(string.Empty))
                {
                    if (password.Length >= 6 && passwordC.Length >= 6)
                    {
                        if (password.ToLower().Equals(passwordC.ToLower())
                        {
                            Console.WriteLine("passwords match");
                        }
                        else
                        {
                            Console.WriteLine("password do not match");
                        }

                    }
                    else
                    {
                        Console.WriteLine("please enter  6 or more charactres");
                    }


                }

                else
                {
                    Console.WriteLine("please enter password confirmation");
                }

            }
            else
            {
                Console.WriteLine("please enter a password");
            }



            // Arrays

            int n1 = 5;
            int n2 = 4;
            int n3 = 3;

            int total1 = n1 + n2 + n3;

            int[] numbers = new int[3];

            numbers[0] = 5;
            numbers[1] = 4;
            numbers[2] = 5;


            Console.WriteLine("Enter a number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{n1}{n2}{n3}");
            Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}");
            }







            // count angel

            const int angleCount = 3;

            int[] angles = new int[angleCount];

            for (int i = 0; i < angles.Length; i++)
            {
                Console.Write($"Enter angle {i + 1}: ");
                Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;

            foreach (int angle in angles)
            {
                angleSum += angle;
            }

            Console.WriteLine(angleSum);


            Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");




            //array sorting

            int[] n4 = new int[]
            {
                1,2,3,4,5,6,7,8,9
            };

            //string test0 = "";
            // test0.Replace("", "");

            Array.Sort(n4);

            foreach (int num0 in n4)
            {
                Console.WriteLine($"{num0}");
            }



            //Array Reversal

            int[] numbers0 = new int[]
            {
                0,1,2,3,4,5
            };

            int[] sortedNumbers = new int[numbers0.Length];


            int x0 = 0;

            for (int i = numbers0.Length - 1; i >= 0; i--)
            {
                sortedNumbers[x] = numbers0[i];
                x++;
            }

            // Array.Reverse(numbers0);

            /*foreach ( var item in numbers0)
            {
                Console.WriteLine($"{item}");
            }*/



            //Array Clearing

            int[] numbers00 = new int[]
            {
                0,1,2,3,4,5
            };

            // Array.Clear(numbers00, 0, numbers00.Length);

            Array.Clear(numbers, 5, 5);

            /* for (int i = 0; i < numbers00.Length; i++) 
            {
                numbers00[i] = default;
            }*/

            foreach (var item in numbers00)
            {
                Console.WriteLine($"{item}");
            }


            //Array Indexof

            int[] num0 = new int[]
            {
                90, 199, 22, 50, 30
            };

            Console.Write("Enter number to search");

            int sear = Convert.ToInt32(Console.ReadLine());

            /* 
             * 
             * 
             * int position =  Array.IndexOf(numbers, sear);

              if (position > -1)
              {
                  Console.WriteLine($"Number {sear} has been found at position {position + 1}");
              }
              else 
              {
                  Console.WriteLine($"Number {sear} has not been found");
              }*/

            int position = -1;

            for (int i = 0; i < sear.Length; i++)
            {
                if (num0[i] == sear)
                {
                    position = i;
                }
            }


            if (position > -1)
            {
                Console.WriteLine($"Number {sear} has been found at position {position + 1}");
            }
            else
            {
                Console.WriteLine($"Number {sear} has not been found");
            }



            //Lists

            int[] number000 = new int[6]
            {
                0, 1, 2, 3, 4, 5
            };

            List<int> listNumbers = new List<int>();


            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number");
                ListNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }

            listNumbers.RemoveAt(0);

            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }


            //Dictionary

            Dictionary<int, string> nam = new Dictionary<int, string>
            { 
                //names.Add(1, "Aba");
                //key value pair
                
                { 1, "ab"},
                { 2, "ab"},
                { 3, "ab"}

            };

            for (int i = 0; i < nam.Count; i++)
            {
                KeyValuePair<int, string> pair = nam.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");

            }

            foreach (KeyValuePair<int, string> item in nam)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }


            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Math", "Aba" },
                {"Science", "Test" }
            };

            //     Console.WriteLine(teachers["Math"]);

            if (teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine(teacher);

                teachers["Math"] = "Joe";
            }
            else
            {
                Console.WriteLine("Math teacher not found");
            }


            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Math not found");
            }


            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }


            // Odd/Even number split

            List<int> odd = new List<int>();

            List<int> even = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }

            }


            Console.WriteLine("print even number");


            foreach (var item in even)
            {
                Console.Write($"{item}");
            }


            Console.WriteLine(Environment.NewLine + "Printing odd numbers");


            foreach (var item in odd)
            {
                Console.WriteLine($"{item}");
            }


            //Array of multiples

            int num11 = 7;
            int length = 5;
            int[] result1 = new int[length];
            int counter = 0;

            for (int i = 1; i <= result1.Length; i++)
            {
                result1[counter] = num11 * i;
                counter++;
            }

            foreach (var item in result1)
            {
                Console.WriteLine($"{item}");
            }
            Console.ReadLine();


            //void functions 
            /*
          bool success0 =   int.TryParse("123", out int result0);
           
            Console.WriteLine(success);

        }*/

            if (int.TryParse("123", out int result0))
            {
                Console.WriteLine(result0);
            }


            /* calculate are of triangle*/


            Console.Write("Enter Width:");

            int width = ReadInt("Enter Width");


            Console.Write("Enter height:");

            int height = ReadInt("Enter Height:");

            Console.ReadLine();

            }



        private static int ReadInt(string message)
        {
            Console.Write(message);

           return Convert.ToInt32(Console.ReadLine());
        }





    }
}

//class 
/*
class Test
{
    public void something()
    {
        Console.WriteLine();
    }
}*/


//functions
/* static void welcomeMessage()
 {
     Console.WriteLine("Welcome Nour");
 }*/



// 

// Test test = new Test();     
//test.something();
//welcomeMessage();






