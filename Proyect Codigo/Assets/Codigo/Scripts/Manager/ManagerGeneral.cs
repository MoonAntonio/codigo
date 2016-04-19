using UnityEngine;
using System.Collections;

public class ManagerGeneral : MonoBehaviour
{
    void Awake()
    {
        // Dont destroy this gameobject never.
        DontDestroyOnLoad(this.gameObject);
    }
}
