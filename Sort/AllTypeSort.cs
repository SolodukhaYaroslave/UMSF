using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class AllTypeSort
    {
        public char[] Bubble_Sort(char[] ChArray)
        {
            for (int i = 1; i < ChArray.Length; i++)
            {
                for (int j = 0; j < ChArray.Length - i; j++)
                {
                    if (ChArray[j] > ChArray[j + 1])
                    {
                        ChArray = Swap(ChArray, j, j + 1);
                    }
                }
            }
            return ChArray;
        }
        public char[] Selection_Sort(char[] ChArray)
        {
            for (int i = 0; i < ChArray.Length; i++)
            {
                int minInd = i;
                for (int j = i +1; j < ChArray.Length; j++)
                {
                    if (ChArray[minInd] > ChArray[j])
                    {
                        minInd = j;
                    }
                }
                ChArray = Swap(ChArray, minInd, i);
            }
            return ChArray;
        }
        public char[] Insertion_Sort(char[] ChArray)
        {
            for (int i = 1; i < ChArray.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (ChArray[i] < ChArray[j])
                    {
                        Swap(ChArray, j, i);
                        i = j;
                    }
                    else break;
                }
            }
            return ChArray;
        }
        static char[] Swap(char[] ch, int in1, int in2)
        {
            char temp = ch[in1];
            ch[in1] = ch[in2];
            ch[in2] = temp;
            return ch;
        }
    }
}
