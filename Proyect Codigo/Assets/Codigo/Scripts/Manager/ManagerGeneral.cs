//////////////////////////////////////////////////////////////////////
//                                                                  //
//  * Autor: lPinchol Moon                                          //
//  * Date: 20/04/2016                                              //
//  * DateMod: 20/04/2016                                           //
//                                                                  //
//                                                                  //
//  * Info: Manager control all game.                               //
//                                                                  //
//////////////////////////////////////////////////////////////////////

#region Using
using UnityEngine;
#endregion

/// <summary>
/// <para>Manager control all game.</para>
/// </summary>
public class ManagerGeneral : MonoBehaviour
{
    #region Methods Init
    /// <summary>
    /// <para>Init in Start.</para>
    /// </summary>
    private void Awake()// Init in Start
    {
        Init();
    }

    /// <summary>
    /// <para>Initializer Manager General.</para>
    /// </summary>
    public void Init()// Initializer Manager General
    {
        // Dont destroy this gameobject never.
        DontDestroyOnLoad(this.gameObject);
    }
    #endregion
}
