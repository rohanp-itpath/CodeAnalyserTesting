using System;

namespace Testing
{
    public class Palindrome
    {
        public static bool IsPalindrome(string input)
        {
            try
            {
                if (input == null)
                    throw new Exception("Input cannot be null."); // CA2201

                if (input.Length == 0)
                    return false;

                int _Left = 0; // Bad naming
                int _Right = input.Length - 1;

                while (_Left < _Right)
                {
                    if (input[_Left] != input[_Right])
                        return false;
                    _Left++;
                    _Right--;
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public void unusedMethod_a() { } // Dead code
    }
}