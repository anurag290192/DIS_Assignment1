using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {

            //We need to enetr the number for lines of pattern needed
            Console.Write("Please Enter Number of lines for the pattern");
            int number = Convert.ToInt32(Console.ReadLine());
            facts(number);

            //We need to enter the number upto which series is required
            Console.Write("Enter the number upto which series is required:");
            string input = Console.ReadLine();
            int number1 = Convert.ToInt32(input);

            PrintSeries(number);
            Console.WriteLine();

            //We need to input time as per earth which we need to get converted in USF time in the code
            Console.WriteLine("Please input the time which need to be transformed in format of HR:MIN:SEC(AM/PM):");
            string input1 = Console.ReadLine();
            string USFTIME = UsfTime(input1);
            Console.WriteLine(USFTIME);
            //Here as num is for the maximium number we want to print in a whole and k is for maximum number in a line
            int num = 110;
            int k = 11;
            UsfNumbers(num, k);

            Console.WriteLine();
            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);

            Console.WriteLine("Enter the number of stones:");
            string input2 = Console.ReadLine();
            int numberofstones = Convert.ToInt32(input2);
            stones(numberofstones);


        }


        public static void facts(int i)
        {
            ////The condition that limites the method for calling itself 
            if (i == 0)

            {
                return;
            }

            //We are decresing the number by 1 and then returning it back to facts(i) 
            facts2(i);
            i = i - 1;
            Console.WriteLine();
            facts(i);

        }

        public static void facts2(int n)
        {
            //The condition that limites the method for calling itself 
            if (n == 0)
            {

                return;
            }
           

            Console.Write(n + " ");
            facts2(n - 1);//The methods calls itself with a new parameter, here!
        }




        private static void PrintSeries(int n2)
        {
            try
            {
                int sum = 0;//sum is intailzed with zero
                for (int i = 1; i <= n2; i++)//For loop will start from 1 and will go on for the number inputed by the user with increment of 1 
                {
                    sum = sum + i;//We are adding number from 1 to the number inputed by the user to sum to calculate the series
                    Console.Write(sum + ",");


                }

            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }


        public static string UsfTime(string input1)
        {
            try
            {
                Console.WriteLine();
                DateTime Earthtime = Convert.ToDateTime(input1);
                Console.WriteLine("You have enetered the time :" + Earthtime.ToLongTimeString());
                int InputedHour = Earthtime.Hour;
                //Here we are adding 12 Hours having Pm as to convert the time into 24 hours of the clock
                if (InputedHour.ToString("tt") == "AM" || InputedHour.ToString("tt") == "Am" || InputedHour.ToString("tt") == "am")
                {
                    InputedHour = InputedHour + 0;
                }
                else if (InputedHour.ToString("tt") == "PM" || InputedHour.ToString("tt") == "Pm" || InputedHour.ToString("tt") == "pm")
                {
                    InputedHour = InputedHour + 12;
                }
                int Secofhr = InputedHour * 60 * 60;
                int Inputedmin = Earthtime.Minute;
                int Secofmin = Inputedmin * 60;
                int Secofsec = Earthtime.Second;
                int TotalSec = Secofhr + Secofmin + Secofsec;
                //Console.WriteLine("Total seconds of enetered time are:" + TotalSec);
                double USFSec = TotalSec / 45;
                //Console.WriteLine(USFSec);
                double USFMin = USFSec / 60;
                //Console.WriteLine(USFMin);
                decimal USFMIN = Convert.ToDecimal(USFMin);
                decimal USFHour = decimal.Truncate(USFMIN);//Truncate function is used to just the decimal part of the decimal without rouding off the number
                String HOUR = Convert.ToString(USFHour);
                //Console.WriteLine("The hours of USF WROLD ARE:" + USFHour);
                decimal USFMIN1 = USFMIN - Math.Truncate(USFMIN);//Number before decimal is find by subtracting decimal number by the truncated number containing numbers after the decimal
                //Console.WriteLine(USFMIN1);
                decimal USFMINS = USFMIN1 * 60;
                //Console.WriteLine(USFMINS);
                decimal USFMINSFINAL = decimal.Truncate(USFMINS);
                String MIN = Convert.ToString(USFMINSFINAL);
                //Console.WriteLine(USFMINSFINAL);
                decimal USFSEC = USFMINS - Math.Truncate(USFMINS);
                //Console.WriteLine(USFSEC);
                decimal USFSEC1 = USFSEC * 45;
                //Console.WriteLine(USFSEC1);
                decimal USFSECFINAL = decimal.Truncate(USFSEC1);
                String SECONDS = Convert.ToString(USFSECFINAL);
                //Console.WriteLine(USFSECFINAL);
                Console.WriteLine(HOUR + ':' + MIN + ':' + SECONDS);
                


            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }


        public static void UsfNumbers(int num, int k)

        {
            try
            {
                Console.WriteLine();
                int count = 0;
                for (int i = 1; i <= num; i++)//For loop would start from1 and will go on untill 110 with increment of 1
                {

                    if (count == k)//K is restricting 11 numbers in a line
                    {
                        count = 0;
                        Console.WriteLine();
                    }
                    //We are using modules operator to check if number is divisible by 3 ,5 and 7 
                    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                    {
                        Console.Write("USF ");
                    }
                    else if (i % 5 == 0 && i % 7 == 0)
                    {
                        Console.Write("SF ");
                    }
                    else if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write("US ");
                    }
                    else if (i % 3 == 0 && i % 7 == 0)
                    {
                        Console.Write("UF ");
                    }
                    else if (i % 7 == 0)
                    {
                        Console.Write("F ");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("S ");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write("U ");
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                    count = count + 1;
                }
            }





            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }

        }



        public static void PalindromePairs(string[] words)
        {
            try
            {
                int length = words.Length;
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        string combine = words[i] + words[j];
                        bool Palindrome = IsPalindrome(combine);
                        if (Palindrome == true)
                        {
                            Console.WriteLine("output array index - [{0},{1}]", i, j);
                            Console.WriteLine("\n");
                        }
                    }
                    //string m = words[i];

                }
            

            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
            static bool IsPalindrome(string value)//Method is used to find out does the given string is palindrome or not
            {
                int min = 0;
                int max = value.Length - 1;
                while (true)
                {
                    if (min > max)
                    {
                        return true;
                    }
                    char a = value[min];
                    char b = value[max];
                    if (char.ToLower(a) != char.ToLower(b))
                    {
                        return false;
                    }
                    min++;
                    max--;
                }
            }

        }
        public static void Entry(int value)
        {
            if (value == 0)
            {
                return;
            }
            Console.WriteLine("1 ");
            Console.WriteLine((value - 1) % 4);
            Entry(value - 4);
        }
        public static void stones(int number)
        {
            if (number % 4 == 0)//As who ever takes the 4th stone from end will lose so we are taking modules of 4
            {
                Console.WriteLine("false");
            }
            else
            {
                int mod = number % 4;
                Console.WriteLine(mod);
                number = number - mod;
                Entry(number);
            }
            return;
        }


    }


}

