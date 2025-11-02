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
        public void ReverseArray(int[] array) //odwróc tablice bez tworzenia nowej
        {
            int temp;
            for (int i = 0; i < array.Length / 2; i++) //WAZNE JEST TO /2
            {
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }


        }

        public int FindMax(int[] array)
        {
            if (array == null || array.Length == 0) throw new Exception("Array is empty");

            int max = array[0];
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];

            }

            return max;
        }

        public int FindMin(int[] array)
        {

            if (array == null || array.Length == 0) throw new Exception("Array is empty");

            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i]) min = array[i];
            }

            return min;
        }

        public int SumArray(int[] array)
        {
            if (array == null || array.Length == 0) throw new Exception("Array is empty");

            int sum = 0;
            foreach (var i in array)
            {
                sum += i;
            }

            return sum;
        }

        public double averageArray(int[] array)
        {
            if (array == null || array.Length == 0) throw new Exception("Array is empty");

            int sum = 0;
            foreach (var i in array)
            {
                sum += i;
            }

            return (double)sum / array.Length;
        }

        public int[] RemoveDuplicates(int[] array) //todo ogarnij
        {
            if (array == null || array.Length == 0)
                return new int[0];

            int uniqueCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < uniqueCount; j++)
                {
                    if (array[i] == array[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    array[uniqueCount] = array[i];
                    uniqueCount++;
                }
            }

            int[] result = new int[uniqueCount];
            Array.Copy(array, result, uniqueCount);
            return result;
        }


        public int[] FindUniqueElements(int[] array) //todo ogarnij
        {
            if (array == null || array.Length == 0)
                throw new Exception("Array is empty");

            int uniqueCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int occurrences = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        occurrences++;
                }

                if (occurrences == 1)
                {
                    array[uniqueCount] = array[i];
                    uniqueCount++;
                }
            }

            int[] result = new int[uniqueCount];
            Array.Copy(array, result, uniqueCount);
            return result;
        }


        public bool IsPalindrome(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                    return false;
            }
            return true;
        }

        public void MoveZerosToEnd(int[] array) //todo ogarnij
        {
            if (array == null || array.Length == 0)
                return;

            int position = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    array[position] = array[i];
                    position++;
                }
            }

            for (int i = position; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }

        //stringi
        
        





        public static void Main(string[] args)
        {
            var leetcode = new Leetcode();
            int[] result =leetcode.RemoveDuplicates([1, 1, 2, 2, 3]);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}