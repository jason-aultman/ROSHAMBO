using System;

namespace ROSHAMBO
{
    public class Roshambo
    {
        public bool Play(string stringOne, string stringTwo)
        {
            return ((stringOne == "Rock" && stringTwo == "Scissors")||(stringOne == "Scissors" && stringTwo == "Paper")||(stringOne == "Paper" && stringTwo == "Rock"));
           
        }
    }
}
