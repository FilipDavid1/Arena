using System;

namespace Arena
{
    public class Fighter
    {
        private string name;
        private int health;
        private int maxHelth;
        private int attack;
        private int defense;
        private Dice dice;

        public Fighter(string name, int helth,  int attack, int defense , Dice dice)
        {
            this.name = name;
            this.health = helth;
            this.maxHelth = helth;
            this.attack = attack;
            this.defense = defense;
            this.dice = dice;
        }

        public override string ToString()
        {
            return name;
        }

        public bool IsAlive()
        {
            if (health > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string HelthGraph()
        {
            string s = "[";
            int entirely = 20;
            double sum = Math.Round(((double) health / maxHelth) * entirely);
            if ((sum == 0) && (IsAlive()))
                sum = 1;
            for (int i = 0; i < sum; i++)
                s += "#";
            s = s.PadRight(entirely + 1);
            s += "]";
            return s;
        }
    }
}