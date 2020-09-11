using System;

namespace ROSHAMBO
{
    public class Roshambo
    {
        public bool Play(string stringOne, string stringTwo)
        {
            if (stringOne == "Rock" && stringTwo == "Scissors") return true;
            return false;
        }
    }
}
