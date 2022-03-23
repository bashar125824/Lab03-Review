using System;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    public class Program
    {
        public static String filePath = "words.txt";
        public static int challenge1()
        {


            int result = 1;
            Console.WriteLine("Please enter 3 numbers : ");
            string[] numbers = Console.ReadLine().Split(' ');

            if (numbers.Length < 3)
            {
                return 0;
            }


            int[] intNumbers = new int[numbers.Length];

            for (int i = 0; i < intNumbers.Length; i++)
            {
                char character = char.Parse(numbers[i]);
                if (Char.IsDigit(character) == false) {
                    numbers[i] = "1";
                }

                intNumbers[i] = Convert.ToInt32(numbers[i]);

            }

            if (intNumbers.Length > 3)
            {
                Console.Write("The product of these 3 numbers is :");

                result = intNumbers[0] * intNumbers[1] * intNumbers[2];
                return result;
            }

            else
            {
                Console.Write("The product of these 3 numbers is :");
                result = intNumbers[0] * intNumbers[1] * intNumbers[2];
                return result;
            }
        }

        public static void challenge2()
        {


            Console.WriteLine("Please Enter a Number Between 2 and 10 : ");
            int number = Convert.ToInt32(Console.ReadLine());


            while (number > 10 || number < 2) {
               
                    Console.WriteLine("Invalid Input , Please Enter a Number Between 2 and 10 : ");
                    number = Convert.ToInt32(Console.ReadLine());
                

            }

            


            int[] numbers = new int[number];

            for (int i = 0; i < number; i++)
            {

                Console.Write($"{i + 1} of {number} : Enter a number :");
                int choices = Convert.ToInt32(Console.ReadLine());
                if (choices < 0)
                {
                    Console.WriteLine("Invalid Input , Please Enter a Positive Number :");
                    Console.Write($"{i + 1} of {number} : Enter a number :");
                    Convert.ToInt32(Console.ReadLine());
                }

                numbers[i] = choices;
            }

            int sum = 0;
            float average = 0.0F;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            average = (float)sum / numbers.Length;

            Console.WriteLine($"The average of these {number} numbers is : {average}");


        }

        public static void challenge3()
        {
            for (int i = 1; i <= 5; i++)
            {
                //for loop to add space
                for (int j = 1; j <= (5 - i); j++)
                {
                    Console.Write(" ");
                }
                //for loop to print *, for each line 
                //k < i *2
                //so for example, if i =1, it will print star for 1 times, as loop will work  until k < 2, that is 1 time
                // when i = 2, condition will be k < 4, means it will print star for 3 times
                // and so on.
                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //loop to print inverted equilateral triangle
            for (int i = 5 - 1; i >= 1; i--)
            {
                //for loop to add space
                for (int j = 1; j <= (5 - i); j++)
                {
                    Console.Write(" ");
                }
                //for loop to print *, for each line 
                //k < i *2
                //so for example, if i =1, it will print star for 1 times, as loop will work  until k < 2, that is 1 time
                // when i = 2, condition will be k < 4, means it will print star for 3 times
                // and so on.
                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static int challenge4() {

            Console.WriteLine(" Program to get the most frequent element in an array ");

            Console.WriteLine(" **************************************************** ");


            Console.WriteLine(" Enter array size please : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++) {
                Console.WriteLine(" Enter array elements : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
;            }
            // find the max frequency using
            // linear traversal
            int max_count = 1, res = arr[0];
            int curr_count = 1;

            for (int i = 1; i < size; i++)
            {
                if (arr[i] == arr[i - 1])
                    curr_count++;
                else
                {
                    if (curr_count > max_count)
                    {
                        max_count = curr_count;
                        res = arr[i - 1];
                    }
                    curr_count = 1;
                }
            }

            // If last element is most frequent
            if (curr_count > max_count)
            {
                max_count = curr_count;
                res = arr[size - 1];
            }

            return res;



        }

        public static int challenge5()
        {

            Console.WriteLine(" Program to get the maximum element in an array ");

            Console.WriteLine(" **************************************************** ");


            Console.WriteLine(" Please Enter array size : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++) {
                Console.WriteLine(" Enter aray elements : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Sorting array 

            int temp;

            // traverse 0 to array length
            for (int i = 0; i < arr.Length - 1; i++)
            {

                // traverse i+1 to array length
                for (int j = i + 1; j < arr.Length; j++)
                {

                    // compare array element with 
                    // all next element
                    if (arr[i] < arr[j])
                    {

                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            // Find maximum element
            int maxElement = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                    maxElement = arr[i];
            }
            return maxElement;
        }

        public static void challenge6() {

            // Add words to filePath  ..
            //String content = "Hello Hi Sunday Tomorrow Yesterday";
            //File.WriteAllText(filePath, content);

            Console.WriteLine(" Enter a Word please : ");
            string word = Console.ReadLine();

            //the space for make the words separate from each other .
            File.AppendAllText(filePath ," " + word);
            Console.WriteLine($" {word} is added to words.txt ");

            
        }

        static void challenge7() {

            
            Console.WriteLine(" Contents of word.txt file : ");
            Console.WriteLine(File.ReadAllText(filePath));
            
        }

        public static void challenge8() {

           
            
            string read = File.ReadAllText(filePath);
            string[] words = new string [read.Length];
            words = read.Split(' ');
            Console.WriteLine(File.ReadAllText(filePath));
            Console.WriteLine("Enter a word you want to delete : ");
            string choice = Console.ReadLine();
            string wordBeforeDelete = choice;


            // Delete Choosen word in word.txt

            choice = "";

            File.AppendAllText(filePath, " " + choice);

            Console.WriteLine($" {wordBeforeDelete} word is deleted . ");

            Console.WriteLine($" word.txt after delete {wordBeforeDelete} word : " + File.ReadAllText(filePath));

            // Re-write Choosen word

            choice = wordBeforeDelete;
            File.AppendAllText(filePath, " " + choice);

            Console.WriteLine($" word.txt after Re-write {choice} word : " + File.ReadAllText(filePath));


        }

        public static void challenge9() {

            Console.WriteLine(" Enter a sentance : ");
            string sentance = Console.ReadLine();
            string[] splitSen = sentance.Split(" ");
            string[] res = new string[splitSen.Length];
            int [] count = new int [splitSen.Length];
            

            
            for (int i = 0; i< splitSen.Length; i++) {
                count[i] = splitSen[i].Length;
                splitSen[i] = splitSen[i] + " : " + count[i];
                Console.Write($" '{splitSen[i]}' " + " ");
            }

            
        
        } 

        static void Main(string[] args)
        {

            //Console.Write(challenge1());
            challenge2();
            //challenge3();


            //Console.WriteLine("output : " + challenge4());
            //Console.WriteLine("Maximum element : " + challenge5());

            //challenge6();
            //challenge7();
            //challenge8();
            //challenge9();

           

        }
    }
}
