using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LinearMultiplication))]
[CanEditMultipleObjects]
public class LinearMultiplicationInspector : Editor
{
    LinearMultiplication linearMultiplication;

    public void OnEnable()
    {
        linearMultiplication = (LinearMultiplication)target;
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        if (GUILayout.Button("Execute"))
        {
            bool[] result = linearMultiplication.execute();
            string verbose = "";
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i])
                    verbose += "1, ";
                else
                    verbose += "0, ";
            }
            Debug.Log(verbose);
        }
    }
}