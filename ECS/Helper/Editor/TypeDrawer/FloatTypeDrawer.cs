#if UNITY_EDITOR
using System;
using UnityEditor;

public class FloatTypeDrawer : ITypeDrawer
{
    public bool HandlesType(Type type)
    {
        return type == typeof(float);
    }

    public object DrawAndGetNewValue(Type memberType, string memberName, object value, object target)
    {
        return EditorGUILayout.FloatField(memberName, (float) value);
    }
}
#endif
