using System;
using System.Collections.Generic;

namespace MidtermExam.Prob01
{
    public class VowelCounter
    {
        public int AS01_CountVowels(Queue<string> alphabets)
        {
            if (alphabets == null || alphabets.Count == 0)
            {
                return 0;
            }
            int count = 0;
            int size = alphabets.Count;
            for (int i = 0; i < size; i++)
            {
                string letter = alphabets.Dequeue();
                if (letter == "a" || letter == "e" ||
                    letter == "i" || letter == "o" ||
                    letter == "u")
                {
                    count++;
                }
                alphabets.Enqueue(letter);
            }
            return count;
        }
    }
}
