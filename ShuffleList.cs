using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ListExtensions
{
    // Method to shuffle a List using the Fisher-Yates shuffle algorithm
    public static void Shuffle<T>(this List<T> list)
    {
        int n = list.Count;
        for (int i = n - 1; i > 0; i--)
        {
            // Generate a random index between 0 and i (inclusive)
            int randomIndex = Random.Range(0, i + 1);

            // Swap elements at randomIndex and i
            T temp = list[i];
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
}
