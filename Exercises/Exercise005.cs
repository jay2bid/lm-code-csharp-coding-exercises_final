using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;

            foreach (char letter in alphabet)
            {
                foreach (char letterInput in input.ToLower())
                {
                    if (letter == letterInput)
                    {
                        count++;
                        break;
                    }
                }
            }
            return count == 26;

        }
    }
}