namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            Console.WriteLine(nums[1]);

            string[] pets = { "cat", "dog", "bird" };
            Console.WriteLine(pets.Length);

            for (int i = 0; i < pets.Length; i++)
            {
                Console.WriteLine(pets[i]);
            }

            Console.WriteLine();
            int[] numbers = { 1, 2, 3, 4 };
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * 2;
                Console.WriteLine(numbers[i]);
            }

            int[] numms = { 5, 10, 15, 20 };
            bool isCOntain = numms.Contains(15);
            if (isCOntain) Console.WriteLine("Found");
            else Console.WriteLine("Not Found");

            int[,] ints = {{ 1, 2 },{ 3,4} };
            Console.WriteLine(ints[1,0]);

            /*//Arrays
            //Create and initialize
            int[] nums = { 1, 2, 3, 4, 5 };


            //Create without initialize,but with size of array
            string[] names = new string[5];
            names[0] = "Duman";
            names[1] = "Er";
            
            //Length of Array
            int lengthOfNames = names.Length;

            //Check if array contains
            bool isContain = names.Contains("Duman");

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //Matrix
            int[,] matrix = { { 1, 2 }, { 3, 4 } };
            Console.WriteLine(matrix[1,1]);
            Console.WriteLine();*/


        }
    }
}
