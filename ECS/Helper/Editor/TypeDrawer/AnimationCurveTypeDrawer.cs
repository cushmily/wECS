#if UNITY_EDITOR
using System;
using UnityEditor;
using UnityEngine;

public class AnimationCurveTypeDrawer : ITypeDrawer
{
    public bool HandlesType(Type type)
    {
        return type == typeof(AnimationCurve);
    }

    public object DrawAndGetNewValue(Type memberType, string memberName, object value, object target)
    {
        return EditorGUILayout.CurveField(memberName, (AnimationCurve) value);
    }
}
#endif
