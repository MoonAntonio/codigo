//////////////////////////////////////////////////////////////////////
//                                                                  //
//  * Autor: lPinchol Moon                                          //
//  * Date: 20/04/2016                                              //
//  * DateMod: 20/04/2016                                           //
//                                                                  //
//                                                                  //
//  * Info: Manager control global data.                            //
//                                                                  //
//////////////////////////////////////////////////////////////////////

#region Using
using UnityEngine;
#endregion

/// <summary>
/// <para>Manager control global data.</para>
/// </summary>
public class ManagerSave : MonoBehaviour
{
    #region Var Static
    /// <summary>
    /// <para>Version Proyect.  (Format:"0.0.6a")</para>
    /// </summary>
    public const string _version = "0.0.10a";                // Version Proyect (Format:"0.0.6a")
    /// <summary>
    /// <para>(Global)Date Copilers number.</para>
    /// </summary>
    public static int _intCopiler;                          // (Global)Date Copiler number
    /// <summary>
    /// <para>(Global)Date Bugs number.</para>
    /// </summary>
    public static int _intBug;                              // (Global)Date Bugs number
    /// <summary>
    /// <para>Volume general</para>
    /// </summary>
    public static int _volG = 5;                            // Volume general
    #endregion

    #region Var Public
    [Range(0.0f,999.9f)]
    public int intCopiler;
    [Range(0.0f, 999.9f)]
    public int intBug;
    [Range(0,5)]
    public int volG;
    #endregion

    #region Methods Run
    /// <summary>
    /// <para>Updater.</para>
    /// </summary>
    private void Update()// Updater
    {
        intCopiler = _intCopiler;
        intBug = _intBug;
        volG = _volG;
    }
    #endregion
}
