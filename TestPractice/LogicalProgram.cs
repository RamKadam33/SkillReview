// Author: Ram Kadam
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice
{
    internal class LogicalProgram
    {
        [Test]
        public void reverse()
        {
            string input = "hello";
            string name = "ram";
            char[] chars = input.ToCharArray();
            int left = 0;
            int right = chars.Length - 1;

            while (left < right)
            {
                // Swap characters
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
            }

            string reversed = new string(chars);
            Console.WriteLine(reversed); // Output: "olleh"
        }
        [Test]
        public void missingNumber()
        {
            int[] arr = { 1, 2, 4, 5, 6 }; // Example: missing number is 3
            int n = arr.Length + 1; // Since one number is missing

            int expectedSum = 0;
            for (int i = 1; i <= n; i++)
            {
                expectedSum += i;
            }

            int actualSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                actualSum += arr[i];
            }

            int missingNumber = expectedSum - actualSum;
            Console.WriteLine("Missing number is: " + missingNumber); // Output: Missing number is: 3
        }
        [Test]
        public void palandron()
        {
            string input = "madam";
            bool isPalindrome = true;

            for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                if (input[i] != input[j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a palindrome");
        }
        [Test]
        public void sumOfDigits()
        {
            int[] arr = { 2, 7, 11, 15 };
            int target = 9;
            bool found = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        Console.WriteLine("Numbers: " + arr[i] + " and " + arr[j]);
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }

            if (!found)
                Console.WriteLine("No two numbers found with the target sum.");
        }
        [Test]
        public void analdom()
        {
            string str1 = "listen";
            string str2 = "silent";

            bool isAnagram = true;

            if (str1.Length != str2.Length)
            {
                isAnagram = false;
            }
            else
            {
                char[] arr1 = str1.ToCharArray();
                char[] arr2 = str2.ToCharArray();

                // Sort both character arrays
                for (int i = 0; i < arr1.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr1.Length; j++)
                    {
                        if (arr1[i] > arr1[j])
                        {
                            char temp = arr1[i];
                            arr1[i] = arr1[j];
                            arr1[j] = temp;
                        }
                        if (arr2[i] > arr2[j])
                        {
                            char temp = arr2[i];
                            arr2[i] = arr2[j];
                            arr2[j] = temp;
                        }
                    }
                }

                // Compare sorted arrays
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        isAnagram = false;
                        break;
                    }
                }
            }

            if (isAnagram)
                Console.WriteLine("Anagram");
            else
                Console.WriteLine("Not an anagram");
        }
        [Test]
        public void checkBracket()
        {
            string input = "{[()]}";
            bool isBalanced = true;
            char[] stack = new char[input.Length];
            int top = -1;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack[++top] = ch; // Push to stack
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (top == -1)
                    {
                        isBalanced = false;
                        break;
                    }
                    char last = stack[top--]; // Pop from stack
                    if ((ch == ')' && last != '(') ||
                        (ch == '}' && last != '{') ||
                        (ch == ']' && last != '['))
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (top != -1)
                isBalanced = false;

            if (isBalanced)
                Console.WriteLine("Brackets are balanced");
            else
                Console.WriteLine("Brackets are not balanced");

        }
        [Test]
        public void freOfElement()
        {
            char[] arr = { 'a', 'b', 'c', 'a', 'b', 'a' };
            IDictionary<char, int> freq = new Dictionary<char, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                char ch = arr[i];
                if (freq.ContainsKey(ch))
                {
                    freq[ch]++;
                }
                else
                {
                    freq[ch] = 1;
                }
            }

            // Print frequencies
            foreach (var pair in freq)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
        }
        [Test]
        public void ArrayConversation()
        {   
            int index = 0;
            int[,] twoDymen = { { 1, 2, 3,8 }, { 4,5,6,7},{10,11,12,13 } };
            int a = twoDymen.GetLength(0);
            int b=  twoDymen.GetLength(1);
            int[] oneDymen = new int[a * b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    oneDymen[index] = twoDymen[i,j];
                    Console.Write(oneDymen[index] + " ");
                    index++;
                }
            }


        }
        [Test]
        public void ConsecutiveNumbers()
        {

            int[] nums = { 100, 4, 200, 1, 3, 2 };

            int longest = 0;
            if (nums.Length == 0)
            {
                longest=-1;
            }
            else
            {
               HashSet<int> numSet = new HashSet<int>(nums);

            foreach (int num in numSet)
            {
                // Only start counting if num is the start of a sequence
                if (!numSet.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum += 1;
                        currentStreak += 1;
                    }

                    longest = Math.Max(longest, currentStreak);
                }
            }
            }
           
        }
        [Test]
        public void SortSimilarWord()
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            var dict = new Dictionary<string, List<string>>();

            foreach (var word in strs)
            {
                // Sort the characters in the word
                var chars = word.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);

                // Add the word to the corresponding group
                if (!dict.ContainsKey(key))
                    dict[key] = new List<string>();
                dict[key].Add(word);
            }

            foreach (var group in dict.Values)
            {
                Console.WriteLine(string.Join(", ", group));
            }
            
        }
        [Test]
        public void ArrayElementMapping()
        {
            
                string pattern = "abba";
                string s = "dog dog dog dog";
                string[] words = s.Split(' ');

                if (pattern.Length != words.Length)
                {
                    Console.WriteLine(false);
                    return;
                }

                Dictionary<char, string> charToWord = new Dictionary<char, string>();
                Dictionary<string, char> wordToChar = new Dictionary<string, char>();

                for (int i = 0; i < pattern.Length; i++)
                {
                    char c = pattern[i];
                    string w = words[i];
                    // Check if mapping exists and is consistent
                    if (charToWord.ContainsKey(c))
                    {
                        string word = charToWord[c];
                        if (charToWord[c] != w)
                        {
                            Console.WriteLine(false);
                            return;
                        }
                    }
                    else
                    {
                        charToWord[c] = w;
                    }

                // Check reverse mapping for uniqueness
                if (wordToChar.ContainsKey(w))
                {
                    if (wordToChar[w] != c)
                    {
                        Console.WriteLine(false);
                        return;
                    }
                }
                else
                {
                    wordToChar[w] = c;
                }
                }

                Console.WriteLine(true);
            }
        

    }
    }
    

