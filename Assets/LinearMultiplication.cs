using UnityEngine;
using System.Collections;

public class LinearMultiplication : MonoBehaviour {
    Matrix matrix;
    Vector vector;

    public bool[] execute()
    {
        vector = this.GetComponent<Vector>();
        matrix = this.GetComponent<Matrix>();
        bool[] values = new bool[vector.values.Length];
        for(int i = 0; i < values.Length; i++)
        {
            for(int j = 0; j < values.Length; j++)
            {
                if (vector.values[j] && matrix.values[i, j])
                {
                    values[i] = true;
                    break;
                }
            }
        }
        return values;
    }
}
