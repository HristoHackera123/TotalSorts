namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 0; j < nums.Length-1; j++)
                {
                    if (nums[j] > nums[j+1])
                    {
                        int swap = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = swap;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
