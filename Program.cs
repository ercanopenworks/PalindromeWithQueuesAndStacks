using System;
using System.Collections;
using System.Collections.Generic;

namespace PalindromeWithQueuesAndStacks
{
    class Program
    {
        private static Stack<char> myStack = new Stack<char>();
        private static Queue<char> myQue = new Queue<char>();

        public static void pushCharacter(char ch)
        {
            myStack.Push(ch);

        }

        public static void enqueueCharacter(char ch)
        {
            myQue.Enqueue(ch);
        }

        public static char popCharacter()
        {
            return myStack.Pop();

        }

        public static char dequeueCharacter()
        {
            return myQue.Dequeue();
        }
        static void Main(string[] args)
        {
            string str = "racecar";
            bool isPalindrome = true;

            foreach(char item in str.ToCharArray())
            {
                pushCharacter(item);
                enqueueCharacter(item);

            }

            for (int i = 0; i < str.Length-1; i++)
            {
                var stackItem = popCharacter();
                var queItem = dequeueCharacter();

                if (stackItem != queItem)
                {
                    isPalindrome = false;
                    break;
                }                
            }

            if(myQue.Count==0 && myStack.Count == 0)
            {
                isPalindrome = true;
            }

            if (isPalindrome)
            {
                Console.WriteLine($"The word, {str}, is a palindrome");
            }
            else
            {
                Console.WriteLine($"The word, {str}, is not a palindrome");
            }
            

        }
    }
}
