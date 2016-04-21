//////////////////////////////////////////////////////////////////////
//                                                                  //
//  * Autor: lPinchol Moon                                          //
//  * Date: 21/04/2016                                              //
//  * DateMod: 21/04/2016                                           //
//                                                                  //
//                                                                  //
//  * Info: Control funcionality Menu Scene.                        //
//                                                                  //
//////////////////////////////////////////////////////////////////////

#region Using
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#endregion

/// <summary>
/// <para>Control funcionality Menu Scene.</para>
/// </summary>
public class ControlMenu : MonoBehaviour
{
    #region Var Public
    /// <summary>
    /// <para>Panel Options</para>
    /// </summary>
    public GameObject panelOptions;                             // Panel Options
    /// <summary>
    /// <para>Panel Credits</para>
    /// </summary>
    public GameObject panelCredits;                             // Panel Credits
    /// <summary>
    /// <para>Text version</para>
    /// </summary>
    public Text txtVersion;                                     // Text version
    /// <summary>
    /// <para>Text version Creditos</para>
    /// </summary>
    public Text txtVersionC;                                     // Text version Creditos
    /// <summary>
    /// <para>Control opciones script</para>
    /// </summary>
    public ControlOptions controlOptions;                       // Control opciones script
    #endregion

    #region Var Private
    /// <summary>
    /// <para>Name Scene to continue.</para>
    /// </summary>
    private string nameScene = "Game";                          // Name Scene to continue
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
        txtVersion.text = ManagerSave._version;
        txtVersionC.text = txtVersion.text;
        controlOptions.UpdateColorVol(ManagerSave._volG);
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

    /// <summary>
    /// <para>Open Opciones Menu</para>
    /// </summary>
    public void ClickOptions()// Open Opciones Menu
    {
        panelOptions.SetActive(true);
    }

    /// <summary>
    /// <para>Open Credits Menu</para>
    /// </summary>
    public void ClickCredits()// Open Credits Menu
    {
        panelCredits.SetActive(true);
    }

    /// <summary>
    /// <para>Close Opcions Menu</para>
    /// </summary>
    public void CloseOptions()// Close Opcions Menu
    {
        panelOptions.SetActive(false);
    }

    /// <summary>
    /// <para>Close Credits Menu</para>
    /// </summary>
    public void CloseCredits()// Close Credits Menu
    {
        panelCredits.SetActive(false);
    }
    #endregion
}
