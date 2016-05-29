using UnityEngine;
using System.Collections;

public class Matrix : MonoBehaviour {
    public int dimensions = 3;
    public bool[,] values = new bool[3,3];

    public void updateDimensions()
    {
        values = new bool[dimensions, dimensions];
    }
}
