using System;

namespace ROSHAMBO
{
    public class Roshambo
    {
        public bool Play(string stringOne, string stringTwo)
        {
            if (stringOne == "Rock" && stringTwo == "Scissors") return true;
            else if (stringOne == "Scissors" && stringTwo == "Paper") return true;
            else if (stringOne == "Paper" && stringTwo == "Rock") return true;
            return false;
        }
    }
}
