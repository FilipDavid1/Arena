using System;
using System.Collections.Generic;
using System.Text;

namespace Arena
{
    public class Dice
    {
        
        private int numberOfWAlls;
        private Random random;
        

        
        public Dice(int numberOfWAlls)
        {
            this.numberOfWAlls = numberOfWAlls;
            random = new Random();
        }
        /// <summary>
        /// Returns number of walls of dice
        /// </summary>
        /// <returns>number of walls of dice</returns>
        public int GetNumberOfWalls()
        {
            return this.numberOfWAlls;
        }
        /// <summary>
        /// Throws the dice.
        /// </summary>
        /// <returns>random number from 1 to number of walls of the dice</returns>
        public int Trow()
        {
            return this.random.Next(1, this.numberOfWAlls);
        }
        /// <summary>
        /// Returns text representation of the dice.
        /// </summary>
        /// <returns>text representation of the dice</returns>
        public override string ToString()
        {
            return String.Format($"Dice with {this.numberOfWAlls} walls");
        }
    }
}
