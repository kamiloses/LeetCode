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

        public string ReverseString(string str)
        {
            if (str == null)
                throw new Exception("String is null");

            char[] charArray = str.ToCharArray();
            int n = charArray.Length;

            for (int i = 0; i < n / 2; i++)
            {
                char temp = charArray[i];
                charArray[i] = charArray[n - 1 - i];
                charArray[n - 1 - i] = temp;
            }

            return new string(charArray);
        }

        public bool IsPalindrome(string str)
        {
            if (str == null)
                throw new Exception("String is null");

            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            return str == reversed;
        }

        public char FindMostFrequentChar(string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new Exception("String is null or empty");

            var signs = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!signs.ContainsKey(str[i]))
                {
                    signs.Add(str[i], 1);
                }
                else
                {
                    signs[str[i]] += 1;
                }

            }

            int max = 0;
            char c = ' ';

            foreach (var sign in signs)
            {
                if (sign.Value > max)
                {
                    max = sign.Value;
                    c = sign.Key;
                }
            }



            return c;
        }

        public string RemoveSpaces(string str)
        {
            if (str == null)
                throw new Exception("String is null");

            string result = "";

            foreach (char c in str)
            {
                if (c != ' ')
                    result += c;
            }

            return result;
        }
//"listen" i "silent" → anagramy
        public bool AreAnagrams(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                throw new Exception("One or both strings are null");

            if (str1.Length != str2.Length)
                return false;

            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true; 
        }

        public void FindFirstUniqueWord(string str)//void celowo dałem
        {
            //czyli znowu hashmapa i poprostu sprawdzam ile tych samóch słow jest i np 1 element ma wysstepowania a ja szukam 1 elementu w hashmapie gdzie klucz ma tylko 1 wartosc
        }


        public void ReverseWords(string sentence)//public string ReverseWords(string sentence);
        {
            //czyli wystarczy split(" ") i wtedy odwrocona petla bo to nie bedzie literek odwracać tylko wyraz w innej kolejnosci czyli "ab" "bc" "cd" na "cd" "bc" "ab"
            
            
        }
        public string ReplaceChar(string str, char oldChar, char newChar)
        {
            if (str == null)
                throw new Exception("String is null");

            char[] result = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == oldChar)
                    result[i] = newChar;
                else
                    result[i] = str[i];
            }

            return new string(result);
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public bool IsPrime(int number)
        {
            if (number <= 1)
                return false; 

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    return false; 
            }

            return true; 
        }

        public int GCD(int a, int b)//najwiekszy dzielnik
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
          //26

        public static void Main(string[] args)
        {
            var leetcode = new Leetcode();
            int[] result =leetcode.RemoveDuplicates([1, 1, 2, 2, 3]);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}