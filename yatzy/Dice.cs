using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yatzy
{
    public class Dice
    {

        //Sorteringsmetod som används för lättare uträkning vid vissa metoder.
        public static int[] SortByDescending(int[] nr)
        {
            Array.Sort<int>(nr,
                            new Comparison<int>(
                                    (i1, i2) => i2.CompareTo(i1)
                            ));
            return nr;
        }
        //ones
        public static int Ones(int[] ones)
        {
            int score = 0;
            foreach (var item in ones)
            {
                if (item == 1)
                {
                    score += item;
                }
            }
            return score;
        }
        //twos
        public static int Twos (int[] twos)
        {
            int score = 0;
            foreach (var item in twos)
            {
                if (item == 2)
                {
                    score += item;
                }
            }
            return score;
        }
        //threes
        public static int Threes(int[] threes)
        {
            int score = 0;
            foreach (var item in threes)
            {
                if (item == 3)
                {
                    score += item;
                }
            }
            return score;
        }
        //fours
        public static int Fours(int[] fours)
        {
            int score = 0;
            foreach (var item in fours)
            {
                if (item == 4)
                {
                    score += item;
                }
            }
            return score;
        }
        //fives
        public static int Fives(int[] fives)
        {
            int score = 0;
            foreach (var item in fives)
            {
                if (item == 5)
                {
                    score += item;
                }
            }
            return score;
        }
        //sixes
        public static int Sixes(int[] sixes)
        {
            int score = 0;
            foreach (var item in sixes)
            {
                if (item == 6)
                {
                    score += item;
                }
            }
            return score;
        }
        //pair
        public static int Pair(int[] pair)
        {
            pair = SortByDescending(pair);
            int score = 0;
            score += pair[0];
            score += pair[1];
            return score;
        }
        //triples
        public static int Triplets(int[] triplets)
        {
            int score = 0;
            score += triplets[0];
            score += triplets[1];
            score += triplets[2];
            return score;
        }
        //four of a kind
        public static int FourKind(int[] fourKind)
        {
            int score = 0;
            score += fourKind[0];
            score += fourKind[1];
            score += fourKind[2];
            score += fourKind[3];
            return score;
        }
        //small straight
        public static int SmallStraight()
        {
            int score = 15;
            return score;
        }
        //large straight
        public static int LargeStraight()
        {
            int score = 20;
            return score;
        }
        //full house
        public static int FullHouse(int[] fullHouse)
        {
            int score = 0;
            fullHouse = SortByDescending(fullHouse);
            //Kontrollera för legitim kåk
            if ((fullHouse[0] == fullHouse[1]) && (fullHouse[2] == fullHouse[3]) && (fullHouse[3] == fullHouse[4]) || 
                (fullHouse[3] == fullHouse[4]) && (fullHouse[0] == fullHouse[1]) && (fullHouse[1] == fullHouse[2]))
            {
                foreach (var item in fullHouse)
                {
                    score += item;
                }
            }
            else
            {
                //do nothing
            }
            return score;
        }
        //chance
        public static int Chance(int[] chance)
        {
            int score = 0;
            foreach (var item in chance)
            {
                score += item;
            }
            return score;
        }
        //yatzy
        public static int Yatzy()
        {
            int score = 50;
            return score;
        }
    }
}
