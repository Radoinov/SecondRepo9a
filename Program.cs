using System.Diagnostics;

namespace Arrays_With_Commands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the elements in array: ");
            string[] arr = Console.ReadLine().Split().ToArray();

            int commandCount = int.Parse(Console.ReadLine());

            for (int command = 0; command < commandCount; command++)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Reverse":
                        Array.Reverse(arr);
                        break;
                    case "Distrinct":
                        string[] resultArr=arr.Distinct().ToArray();
                        arr = resultArr;
                        break;
                    default:
                        string[] comands = input.Split().ToArray();
                        int index = int.Parse(comands[1]);
                        if (comands[0] == "Repleace") 
                        {
                            arr[ index ] = comands[2];
                        }
                        break;
                }
                Console.WriteLine(string.Join(", ", arr));
            }
        }
    }
}
