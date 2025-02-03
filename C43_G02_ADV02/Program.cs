using System.Collections;

namespace C43_G02_ADV02
{
    // Create a generic class named FixedSizeList<T>.
    internal class FixedSizeList<T>
    {
        private T[] values;
        private int size, capacity;
        public FixedSizeList(int capacity)
        {
            this.capacity = capacity;
            values = new T[capacity];
            size = 0;
        }
        public void Add(T value)
        {
            if (size < capacity)
            {
                values[size] = value;
                size++;
            }
            else
            {
                throw new System.Exception("List is full");
            }
        }
        public T Get(int index)
        {
            if (index < size)
            {
                return values[index];
            }
            else
            {
                throw new System.Exception("Invalid Indices");
            }
        }
    }
    internal class Program
    {
        static void ReverseArrayList(ArrayList arrayList)
        {
            int n = arrayList.Count;
            for (int i = 0; i < n / 2; i++)
            {
                object temp = arrayList[i];
                arrayList[i] = arrayList[n - i - 1];
                arrayList[n - i - 1] = temp;
            }
        }

        static List<int> FindEvenNums(List<int> nums)
        {
            List<int> ans = new List<int>();
            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    ans.Add(num);
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {
            #region Question 1
            // You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5};
            //ReverseArrayList(arrayList);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 2
            // You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.
            //List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
            //List<int> ans = FindEvenNums(nums);
            //foreach (var num in ans)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region Question 3

            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(5);
            //fixedSizeList.Add(1);
            //fixedSizeList.Add(2);
            //fixedSizeList.Add(3);
            //fixedSizeList.Add(4);
            //fixedSizeList.Add(5);
            ////fixedSizeList.Add(6);
            //Console.WriteLine(fixedSizeList.Get(0));
            //Console.WriteLine(fixedSizeList.Get(1));

            #endregion

            #region Question 4

            //string str = "WrlloWorld";
            //Dictionary<char, int> charCount = new Dictionary<char, int>();
            //foreach (var ch in str)
            //{
            //    if (charCount.ContainsKey(ch))
            //    {
            //        charCount[ch]++;
            //    }
            //    else
            //    {
            //        charCount[ch] = 1;
            //    }
            //}
            //for (int i= 0;i < str.Length;i++)
            //{
            //    char ch = str[i];
            //    if (charCount[ch] == 1)
            //    {
            //        Console.WriteLine($"The first non-repeated char is at index: {i}");
            //        break;
            //    }
            //}

            #endregion

            #region Question 5

            //Console.WriteLine("Enter the number of elements in the array");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n]; 
            //Console.WriteLine("Enter the number of queries");
            //int q = int.Parse(Console.ReadLine());
            //int[] freq = new int[100010];
            //for (int i = 0; i < freq.Length; i++)
            //{
            //    freq[i] = 0;
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    freq[arr[i]]++;
            //}
            //for(int i = 100009; i > 0; i--)
            //{
            //    freq[i] += freq[i+1];
            //}
            //for (int i = 0; i < q; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    Console.WriteLine(freq[x+1]);
            //}

            #endregion

            #region Question 6
            ////Given a number N and an array of N numbers. Determine if it's palindrome or not
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //bool isPalindrome = true;
            //int s = 0, e = n - 1;
            //while (s < e)
            //{
            //    if (arr[s] != arr[e])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //    s++;
            //    e--;
            //}
            //if (isPalindrome)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            #endregion

            #region Question 7
            //// Given an array, implement a function to remove duplicate elements from an array.
            //int[] arr = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            //HashSet<int> unique = new HashSet<int>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    unique.Add(arr[i]);
            //}
            //foreach (var item in unique)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 8
            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    if ((int)arrayList[i] % 2 != 0)
            //    {
            //        arrayList.RemoveAt(i);
            //        i--;
            //    }
            //}
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

        }
    }
}
