using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class AllTypeSort
    {
        //Пресуває із ліва на право всі найбільші значення
        public char[] Bubble_Sort(char[] ChArray)
        {
            bool isSwapped = true;
            for (int i = 1; isSwapped; i++)
            {
                isSwapped = false;
                for (int j = 0; j < ChArray.Length - i; j++)
                {
                    if (ChArray[j] > ChArray[j + 1])
                    {
                        ChArray = Swap(ChArray, j, j + 1);
                        isSwapped = true;
                    }
                }
            }
            return ChArray;
        }

        //Знаходить найемнще значення в масиві і міняється місцями із попереднім 
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

        //Пренаступний елементі і встановлує його в положення у вже відсортовану частину
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

        //Покращенний бульбашковий метод, переностить значення як із ліва на право, так з права на ліво
        public char[] Cocktail_Sort(char[] ChArray)
        {
            int st = 0, end = ChArray.Length - 1;
            bool isSwapped = true;

            while (isSwapped)
            {
                isSwapped = false;
                for (int j = st; j < end; j++)
                {
                    if (ChArray[j] > ChArray[j + 1])
                    {
                        ChArray = Swap(ChArray, j, j + 1);
                        isSwapped = true;
                    }
                }

                if (!isSwapped) break;

                isSwapped = false;
                end--;

                for (int j = end; j > st; j--)
                {
                    if (ChArray[j - 1] > ChArray[j])
                    {
                        ChArray = Swap(ChArray, j, j -1);
                        isSwapped = true;
                    }
                }
                st++;
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
