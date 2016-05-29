using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(StartTest))]
[CanEditMultipleObjects]
public class StartTestInspector : Editor
{
    StartTest startTest;

    public void OnEnable()
    {
        startTest = (StartTest)target;
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        if (GUILayout.Button("Execute"))
        {
            startTest.execute();
        }

        if (GUILayout.Button("Test Vector 7"))
        {
            Vector vector = startTest.GetComponent<Vector>();
            vector.parse_int(7);
        }
    }
}