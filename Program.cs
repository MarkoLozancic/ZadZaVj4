﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadZaVj4
{
    class Sort
    {
        public static void QuickSort(int[] arr, int left, int right)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            arr[0] = left;
            arr[arr.Length - 1] = right;
            
        }
    }
    internal class Program
    {
        /*Definirajte klasu Sort sa sljedećim članicama:
• statička metoda
void QuickSort(int[] arr, int left, int right) koja će sortirati
proslijeñeni niz u silaznom redoslijedu.
Deklarirajte i definirajte niz arr tipa int s proizvoljnim vrijednostima elemenata, te uz pomoć
metode QuickSort sortirajte niz.
Ispišite sve elemente niza.*/
        public static void Main(string[] args)
        {

            int left, right;
            int[] arr = { 3, 4, 2, 5, 6, 7, 8, 9, 1 };
            left = arr[0];
            right = arr[arr.Length - 1];
            Sort.QuickSort(arr, left, right);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
