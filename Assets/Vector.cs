using UnityEngine;
using System.Collections;
using System.Linq;

public class Vector : MonoBehaviour {
    public bool[] values;

    public int to_i()
    {
        int number = 0;
        for(int i = 0; i < values.Length; i++)
        {
            if (values[i])
                number += (int)Mathf.Pow(2, i);
        }
        return number;
    }

    public void parse_int(int number)
    {
        values = new BitArray(new int[] { number }).Cast<bool>().Take(values.Length).ToArray();
    }
}
