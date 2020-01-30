using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ArrayExpansion : MonoBehaviour
{
    public Array AddToArray(object o, Array a)
    {
        Array b = Array.CreateInstance(a.GetType().GetElementType(), a.Length + 1);
        a.CopyTo(b, 1);
        b.SetValue(o, 0);
        a = b;

        return a;
    }

    public Array AddtoArrayAtIndex(object o, Array a, int index)
    {
        Array b = Array.CreateInstance(a.GetType().GetElementType(), a.Length + 1);

        for (int i = 0; i < index; i++)
        {
            b.SetValue(a.GetValue(i), i);
        }

        for (int i = index + 1; i < b.Length; i++)
        {
            b.SetValue(a.GetValue(i - 1), i);
        }

        b.SetValue(o, index);
        a = b;

        return a;
    }

    public void RemoveAt<T>(ref T[] arr, int index)
    {
        for (int a = index; a < arr.Length - 1; a++)
        {
            arr[a] = arr[a + 1];
        }

        Array.Resize(ref arr, arr.Length - 1);
    }
}
