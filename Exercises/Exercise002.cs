using System;
using Exercises.Models;
namespace Exercises

{
    public class Exercise002
    {

        public bool IsFromManchester(Person personId)
        {
                return personId.city == "Manchester";
        }

        public bool CanWatchFilm(Person personId, int ageLimit)
        {

            return personId.age >= ageLimit;

        }
    }
}
