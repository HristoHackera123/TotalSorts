namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 1; i < nums.Length; i++)
            {   
                int key = nums[i];
                int index = i - 1;
                while (index >= 0 && nums[index] > key)
                {
                    nums[index+1] = nums[index];
                    index--;
                }
                nums[index + 1] = key;
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
