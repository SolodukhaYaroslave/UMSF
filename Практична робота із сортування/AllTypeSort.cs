﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
                for (int j = i + 1; j < ChArray.Length; j++)
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

        //Порівнює і встановлує його в положення у вже із відсортованими елементами
        public char[] Insertion_Sort(char[] ChArray)
        {
            for (int i = 1; i < ChArray.Length; i++)
            {
                int index = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (ChArray[j] > ChArray[i])
                    {
                        index = j;
                    }
                    else break;
                }
                if (index != i)
                {
                    ChArray = Swap(ChArray, index, i);
                    i--;
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
                        ChArray = Swap(ChArray, j, j - 1);
                        isSwapped = true;
                    }
                }
                st++;
            }

            return ChArray;
        }

        //Використання шелла дуже схоже на звичайну перестановку, але робить кроки, що дозволяє пришвидшити сортування
        public char[] Shell_Sort(char[] ChArray)
        {
            int index = 1;
            while (Math.Pow(2, index - 1) < ChArray.Length)
                index++;
            int Step(int s)
            {
                int d;
                // Шелл
                //d = (int) s / 2;

                //Кнут
                index--;
                d = (int)Math.Pow(2, index) - 1;
                return d;
            }

            int step = Step(ChArray.Length);
            while (step >= 1)
            {
                for (int i = step; i < ChArray.Length; i++)
                {
                    int j = i;
                    while ((j >= step) && ChArray[j - step] > ChArray[j])
                    {
                        ChArray = Swap(ChArray, j - step, j);
                        j -= step;
                    }
                }
                step = Step(step);
            }
            return ChArray;
        }

        //Спосіб швидкого сортування
        public void Quick_Sort(ref char[] ChArray, int low, int high)
        {
            int i = low;
            int j = high;
            int pivot = ChArray[low];

            while (i <= j)
            {
                while (ChArray[i] < pivot)
                {
                    i++;
                }

                while (ChArray[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    ChArray = Swap((char[])ChArray, i, j);
                    i++;
                    j--;
                }
            }

            if (low < j) Quick_Sort(ref ChArray, low, j);

            if (i < high) Quick_Sort(ref ChArray, i, high);
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
