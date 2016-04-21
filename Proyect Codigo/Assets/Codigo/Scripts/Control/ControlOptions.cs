//////////////////////////////////////////////////////////////////////
//                                                                  //
//  * Autor: lPinchol Moon                                          //
//  * Date: 21/04/2016                                              //
//  * DateMod: 21/04/2016                                           //
//                                                                  //
//                                                                  //
//  * Info: Control funcionality Menu opcions.                      //
//                                                                  //
//////////////////////////////////////////////////////////////////////

#region Using
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#endregion

/// <summary>
/// <para>Control funcionality Menu opcions.</para>
/// </summary>
public class ControlOptions : MonoBehaviour
{
    #region Var Public
    /// <summary>
    /// <para>Image vol 1 in Options menu.</para>
    /// </summary>
    public Image vol1;                                      // Image vol 1 in Options menu
    /// <summary>
    /// <para>Image vol 2 in Options menu.</para>
    /// </summary>
    public Image vol2;                                      // Image vol 2 in Options menu
    /// <summary>
    /// <para>Image vol 3 in Options menu.</para>
    /// </summary>
    public Image vol3;                                      // Image vol 3 in Options menu
    /// <summary>
    /// <para>Image vol 4 in Options menu.</para>
    /// </summary>
    public Image vol4;                                      // Image vol 4 in Options menu
    /// <summary>
    /// <para>Image vol 5 in Options menu.</para>
    /// </summary>
    public Image vol5;                                      // Image vol 5 in Options menu
    #endregion

    #region Var Private
    private Color32 rojo = new Color32(255, 0, 0, 255);
    private Color32 verde = new Color32(0, 255, 23, 255);
    private Color32 azul = new Color32(0, 223, 255, 255);
    private Color32 negro = new Color32(0, 0, 0, 255);
    private Color32 blanco = new Color32(255, 255, 255, 255);
    #endregion

    #region Methods UI
    /// <summary>
    /// <para>Up Volume</para>
    /// </summary>
    public void VolumenUp()// Up Volume
    {
        if (ManagerSave._volG != 5)
        {
            ManagerSave._volG++;
            UpdateColorVol(ManagerSave._volG);
        }
    }

    /// <summary>
    /// <para>Down volume</para>
    /// </summary>
    public void VolumenDown()// Down volume
    {
        if (ManagerSave._volG != 0)
        {
            ManagerSave._volG--;
            UpdateColorVol(ManagerSave._volG);
        }
    }

    /// <summary>
    /// <para>Send to GitHub</para>
    /// </summary>
    public void FeedBack()// Send to GitHub
    {
        Application.OpenURL("https://github.com/lPinchol/codigo");
    }
    #endregion

    #region Methods Clas
    /// <summary>
    /// <para>Update color for image volume</para>
    /// </summary>
    /// <param name="i">int for color</param>
    public void UpdateColorVol(int i)// Update color for image volume
    {
        switch (i)
        {
            case 0:
                vol1.color = negro;
                vol2.color = negro;
                vol3.color = negro;
                vol4.color = negro;
                vol5.color = negro;
                return;

            case 1:
                vol1.color = azul;
                vol2.color = blanco;
                vol3.color = blanco;
                vol4.color = blanco;
                vol5.color = blanco;
                return;

            case 2:
                vol1.color = azul;
                vol2.color = azul;
                vol3.color = blanco;
                vol4.color = blanco;
                vol5.color = blanco;
                return;

            case 3:
                vol1.color = verde;
                vol2.color = verde;
                vol3.color = verde;
                vol4.color = blanco;
                vol5.color = blanco;
                return;

            case 4:
                vol1.color = verde;
                vol2.color = verde;
                vol3.color = verde;
                vol4.color = verde;
                vol5.color = blanco;
                return;

            case 5:
                vol1.color = rojo;
                vol2.color = rojo;
                vol3.color = rojo;
                vol4.color = rojo;
                vol5.color = rojo;
                return;

            default:
                vol1.color = negro;
                vol2.color = negro;
                vol3.color = negro;
                vol4.color = negro;
                vol5.color = negro;
                return;
        }
    }
    #endregion
}
