using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Matrix))]
[CanEditMultipleObjects]
public class MatrixInspector : Editor
{
    Matrix matrix;

    public void OnEnable()
    {
        matrix = (Matrix)target;
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        if (GUILayout.Button("AddDimension"))
        {
            matrix.dimensions++;
            matrix.updateDimensions();
        }
        if (GUILayout.Button("RemoveDimension"))
        {
            matrix.dimensions--;
            if (matrix.dimensions <= 0) matrix.dimensions = 1;
            matrix.updateDimensions();
        }

        if (GUILayout.Button("Log values"))
        {
            Debug.Log(LogValues());
        }

        for (int i = 0; i < matrix.values.GetLength(0); i++)
        {
            EditorGUILayout.BeginHorizontal();
            for (int j = 0; j < matrix.values.GetLength(1); j++)
            {
                matrix.values[i, j] = EditorGUILayout.Toggle(matrix.values[i, j]);
            }
            EditorGUILayout.EndHorizontal();
        }

    }

    string LogValues()
    {
        string log = "";
        for (int i = 0; i < matrix.values.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.values.GetLength(1); j++)
            {
                if (matrix.values[i, j])
                    log += "1, ";
                else
                    log += "0, ";
            }
            log += "\n";
        }
        return log;
    }
}
