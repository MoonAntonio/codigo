using UnityEngine;
using System.Collections;

public class ManagerSave : MonoBehaviour
{
    public static int _intCopiler;
    public static int _intBug;

    [Range(0.0f,999.9f)]
    public int intCopiler;
    [Range(0.0f, 999.9f)]
    public int intBug;

    public void Update()
    {
        intCopiler = _intCopiler;
        intBug = _intBug;
    }
}
