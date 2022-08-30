using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Exercises.Models;
using System.Linq;
using System.Diagnostics;


namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            string capitalWord = " ";
            if (word == null)
                capitalWord = null;
            else if (word.Length > 0)
            {
                char firstLetter = char.ToUpper(word[0]);
                firstLetter.ToString();
                capitalWord = firstLetter + word.Substring(1);

            }
            else if (word == string.Empty)
                capitalWord = string.Empty;
            return capitalWord;
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            char firstInitialCharacter = firstName[0];
            char lastInatialCharacter = lastName[0];
            string firstNameLetter = firstInitialCharacter.ToString();
            string lastNameLetter = lastInatialCharacter.ToString();
            string seperator = ".";
            string initials = firstNameLetter + seperator + lastNameLetter;
            return initials;
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            double vatAmount = 0;
            double priceVatAdded = 0;
            if (originalPrice < 0)
                throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            if (vatRate < 0)
                throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");
            vatAmount = originalPrice * (vatRate / 100);
            return priceVatAdded = Math.Round(originalPrice + vatAmount, 2);
        }

        public string Reverse(string sentence)
        {
            string result = " ";
            if (sentence != null)
            {
                char[] array = sentence.ToCharArray();
                Array.Reverse(array);
                result = new string(array);
            }
            else if (sentence == null)
            {

                result = null;
            }
            else if (sentence == " ")
            {
                result = " ";

            }
            return result;
        }

        public int CountLinuxUsers(List<User> users)
        {
            int count = 0;
            if (users == null)
            { count = 0; }

            else if (users != null)
            {

                foreach (User user in users)
                {
                    if (user.Type == "Linux")
                    {
                        count++;

                    }
                }
            }
            return count;

        }
    }
}
