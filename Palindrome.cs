using System;

namespace Testing
{
    public class Palindrome
    {
        // Method to check if a string is a palindrome
        public static bool IsPalindrome(string input)
        {
            try 
            {
                if (input == null)
                    throw new System.Exception("Input cannot be null."); // CA2201

                if (input.Length == 0)
                    return false;

                int _Left = 0; // naming violation
                int _Right = input.Length - 1;

                while (_Left < _Right)
                {
                    if (input[_Left] != input[_Right])
                    {
                        return false;
                    }

                    _Left++;
                    _Right--;
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); // general catch
                return false;
            }
        }
        
        public void unusedMethod_a()
        {
            // Empty method body, naming violation
        }
    }
}
