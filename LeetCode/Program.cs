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
        public void ReverseArray(int[] array)//odwróc tablice bez tworzenia nowej
        {
            int temp;
            for (int i = 0; i < array.Length/2; i++)//WAZNE JEST TO /2
            {
                temp=array[i];
                array[i]= array[array.Length - 1 - i];
                array[array.Length - 1 - i]=temp;
            }

          
        }

        public int FindMax(int[] array)
        {
            if(array==null ||array.Length==0) throw new Exception("Array is empty");
            
            int max = array[0];
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max=array[i];
       
            }

            return max;
        }

        public int FindMin(int[] array)
        {
            
            if(array==null ||array.Length==0) throw new Exception("Array is empty");
            
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min>array[i]) min=array[i];
            }

            return min;
        }

        public int SumArray(int[] array)
        {
            if(array==null ||array.Length==0) throw new Exception("Array is empty");
            
            int sum = 0;
            foreach (var i in array)
            {
                sum += i;
            }

            return sum;
        }

        public double averageArray(int[] array)
        {
            if(array==null ||array.Length==0) throw new Exception("Array is empty");
            
            int sum = 0;
            foreach (var i in array)
            {
                sum += i;
            }

            return (double)sum/array.Length;
        }



    }



    public static void Main(string[] args)
   {
       var leetcode = new Leetcode();
       leetcode.FindMin([1, 2, 3]);
   }
}