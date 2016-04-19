//////////////////////////////////////////////////////////////////////
//                                                                  //
//  * Autor: lPinchol Moon                                          //
//  * Date: 20/04/2016                                              //
//  * DateMod: 20/04/2016                                           //
//                                                                  //
//                                                                  //
//  * Info: Control funcionality Intro Scene.                       //
//                                                                  //
//////////////////////////////////////////////////////////////////////

#region Using
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#endregion

/// <summary>
/// <para>Control funcionality Intro Scene</para>
/// </summary>
public class ControlIntro : MonoBehaviour
{
    #region Var Public
    /// <summary>
    /// <para>Text copiray.</para>
    /// </summary>
    public Text txtCopy;                                        // Text copiray
    #endregion

    #region Var Private
    /// <summary>
    /// <para>Name Scene to continue.</para>
    /// </summary>
    private string nameScene = "Menu";                          // Name Scene to continue
    #endregion

    #region Method Init
    /// <summary>
    /// <para>Start first</para>
    /// </summary>
    private void Awake()// Start first
    {
        Init();
    }

    /// <summary>
    /// <para>Initialize control intro.</para>
    /// </summary>
    public void Init()// Initialize control intro
    {
        txtCopy.text = "2016 © lPinchol Moon - ver." + ManagerSave._version;
    }
    #endregion

    #region Methods UI
    /// <summary>
    /// <para>Continue to new Scene.</para>
    /// </summary>
    public void ClickContinue()// Continue to new Scene
    {
        SceneManager.LoadScene(nameScene);
    }
    #endregion
}
