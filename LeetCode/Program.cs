using System.Text;

public class Sorting
{



    int[] BubbleSort(int[] nums)
    {

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    int temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
            }
        }

        return nums;
    }



    public int[] SelectionSort(int[] nums) //https://www.youtube.com/watch?v=EwjnF7rFLns&t=321s
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            int minIndex = i; // zakładamy, że najmniejszy element jest na pozycji i
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] < nums[minIndex])
                {
                    minIndex = j; // zapisujemy indeks najmniejszego elementu
                }
            }

            int temp = nums[i];
            nums[i] = nums[minIndex];
            nums[minIndex] = temp;
        }


        return nums;
    }



    public class Leetcode
    {
        public bool IsPalindrome(string text)
        {
            var stringBuilder = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(text[i]);

            }

            return stringBuilder.ToString().Equals(text);
        }



        public Dictionary<string, int> CountWordOccurrences(string text)
        {
            string[] arr = text.Split(" ");

            var dictionary = new Dictionary<string, int>();

            foreach (string word in arr)
            {
                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, 1);
                }
                else
                {
                    dictionary[word]++;
                }

            }

            return dictionary;
        }
    }


    public int GreatestCommonDivisor(int a, int b)
    {
        int min = Math.Min(a, b);
        int gcd = 1;

        for (int i = 1; i <= min; i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                gcd = i;
            }
        }

        return gcd;
    }



   public static void Main(string[] args)
   {
       Leetcode leetcode = new Leetcode();
       Console.Write(leetcode.CountWordOccurrences("ala ma kota i kot ma ale"));
   }
}