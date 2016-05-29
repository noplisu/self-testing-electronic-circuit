using UnityEngine;
using System.Collections;

public class StartTest : MonoBehaviour {
    public void execute()
    {
        LinearMultiplication linearMultiplication = this.GetComponent<LinearMultiplication>();
        bool[] result = linearMultiplication.execute();
        Vector vector = this.GetComponent<Vector>();
        vector.values = result;
        print(vector.to_i());
    }
}
