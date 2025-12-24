namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Arrays
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


            int[,] matrix = { { 1, 2 }, { 3, 4 } };
            Console.WriteLine(matrix[1,1]);
        }
    }
}
