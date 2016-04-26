//////////////////////////////////////////////////////////////////////
//                                                                  //
//  * Autor: lPinchol Moon                                          //
//  * Date: 26/04/2016                                              //
//  * DateMod: 26/04/2016                                           //
//                                                                  //
//                                                                  //
//  * Info: Manager control zone game.                              //
//                                                                  //
//////////////////////////////////////////////////////////////////////

#region Using
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#endregion

/// <summary>
/// <para>Manager control zone game.</para>
/// </summary>
public class ManagerGame : MonoBehaviour
{
    #region Var Public
    [Space(5)]
    [Header("Panels")]

    /// <summary>
    /// <para>Panel Selection Desk.</para>
    /// </summary>
    public GameObject panelSelection;                               // Panel Selection Desk
    /// <summary>
    /// <para>Panel GameDesk .</para>
    /// </summary>
    public GameObject panelGame;                                    // Panel Game Desk
    /// <summary>
    /// <para>Panel Options Game.</para>
    /// </summary>
    public GameObject panelOptions;                                 // Panel Options Game

    [Space(5)]
    [Header("Img")]

    /// <summary>
    /// <para>Desk 01 in Scene.</para>
    /// </summary>
    public Image imgDesk1;                                          // Desk 01 in Scene
    /// <summary>
    /// <para>Desk 02 in Scene.</para>
    /// </summary>
    public Image imgDesk2;                                          // Desk 02 in Scene
    /// <summary>
    /// <para>Desk 03 in Scene</para>
    /// </summary>
    public Image imgDesk3;                                          // Desk 03 in Scene
    /// <summary>
    /// <para>Desk 04 in Scene</para>
    /// </summary>
    public Image imgDesk4;                                          // Desk 04 in Scene
    /// <summary>
    /// <para>Array Img Source.</para>
    /// </summary>
    public Sprite[] imgArray;                                       // Array Img Source
    /// <summary>
    /// <para 1>Array Img 2 Source.</para>
    /// <para 2>0. Conect</para>
    /// <para 3>4. Cora</para>
    /// <para 4>8. Fuerza</para>
    /// <para 5>12. Hexa</para>
    /// <para 6>16. Kan</para>
    /// <para 7>20. Picas</para>
    /// <para 8>24. Rag</para>
    /// <para 9>28. Rombo</para>
    /// <para 10>32. Treboles</para>
    /// </summary>
    public Sprite[] imgPort2Array;                                  // Array Img 2 Source
    /// <summary>
    /// <para 1>Array Img Content.</para>
    /// <para 2>0. Conect</para>
    /// <para 3>16. Cora</para>
    /// <para 4>32. Fuerza</para>
    /// <para 5>48. Hexa</para>
    /// <para 6>64. Kan</para>
    /// <para 7>80. Picas</para>
    /// <para 8>96. Rag</para>
    /// <para 9>112. Rombo</para>
    /// <para 10>128. Treboles</para>
    /// </summary>
    public Sprite[] imgContentArray;                                // Array Img Content

    [Space(5)]
    [Header("Copiler & Bugs")]

    /// <summary>
    /// <para>Text copiler number in selection.</para>
    /// </summary>
    public Text txtCopilerSelection;                                // Text copiler number in selection
    /// <summary>
    /// <para>Text copiler number in game.</para>
    /// </summary>
    public Text txtCopilerGame;                                     // Text copiler number in game
    /// <summary>
    /// <para>Text bugs number in selection.</para>
    /// </summary>
    public Text txtBugsSelection;                                   // Text bugs number in selection
    /// <summary>
    /// <para>Text bugs number in game.</para>
    /// </summary>
    public Text txtBugsGame;                                        // Text bugs number in game

    [Space(5)]
    [Header("Game")]

    /// <summary>
    /// <para>Text ask for response.</para>
    /// </summary>
    public Text txtPregunta;                                        // Text ask for response
    /// <summary>
    /// <para>Image Desk card.</para>
    /// </summary>
    public Image imgAsk;                                            // Image Desk card
    /// <summary>
    /// <para>Image card ask 1.</para>
    /// </summary>
    public Image imgCard1;                                          // Image card ask 1
    /// <summary>
    /// <para>Image card ask 2.</para>
    /// </summary>
    public Image imgCard2;                                          // Image card ask 2
    /// <summary>
    /// <para>Image card ask 3.</para>
    /// </summary>
    public Image imgCard3;                                          // Image card ask 3
    /// <summary>
    /// <para>Image card ask 4.</para>
    /// </summary>
    public Image imgCard4;                                          // Image card ask 4
    /// <summary>
    /// <para>Slider time from game.</para>
    /// </summary>
    public Slider sliderTime;                                       // Slider time from game

    [Space(5)]
    [Header("Options")]

    /// <summary>
    /// <para>Image vol 1 in Options menu.</para>
    /// </summary>
    public Image vol1;                                              // Image vol 1 in Options menu
    /// <summary>
    /// <para>Image vol 2 in Options menu.</para>
    /// </summary>
    public Image vol2;                                              // Image vol 2 in Options menu
    /// <summary>
    /// <para>Image vol 3 in Options menu.</para>
    /// </summary>
    public Image vol3;                                              // Image vol 3 in Options menu
    /// <summary>
    /// <para>Image vol 4 in Options menu.</para>
    /// </summary>
    public Image vol4;                                              // Image vol 4 in Options menu
    /// <summary>
    /// <para>Image vol 5 in Options menu.</para>
    /// </summary>
    public Image vol5;                                              // Image vol 5 in Options menu
    #endregion

    #region Var Private
    /// <summary>
    /// <para>Number card shuffle.</para>
    /// </summary>
    private int shuffle = 0;                                        // Number card shuffle
    /// <summary>
    /// <para>Aux for Shuffle x </para>
    /// </summary>
    private int auxShuffle = 0;                                     // Aux for Shuffle x 
    /// <summary>
    /// <para>Temporaly number in desk</para>
    /// </summary>
    private int tempLangDesk01 = 0;                                 // Temporaly number in desk
    /// <summary>
    /// <para>Temporaly number in desk</para>
    /// </summary>
    private int tempLangDesk02 = 0;                                 // Temporaly number in desk
    /// <summary>
    /// <para>Temporaly number in desk</para>
    /// </summary>
    private int tempLangDesk03 = 0;                                 // Temporaly number in desk
    /// <summary>
    /// <para>Temporaly number in desk</para>
    /// </summary>
    private int tempLangDesk04 = 0;                                 // Temporaly number in desk

    // Colors
    private Color32 rojo = new Color32(255, 0, 0, 255);
    private Color32 verde = new Color32(0, 255, 23, 255);
    private Color32 azul = new Color32(0, 223, 255, 255);
    private Color32 negro = new Color32(0, 0, 0, 255);
    private Color32 blanco = new Color32(255, 255, 255, 255);
    #endregion

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
        auxShuffle = 0;
        shuffle = 0;
    }
    #endregion

    #region Methods Update
    private void Update()
    {
        if (auxShuffle <= 4)
        {
            for (int i = 0; i < 5; i++)
            {
                shuffle = Random.Range(0, 8);
                auxShuffle++;
                ActiveDesk(shuffle);
            }
            
        }
    }
    #endregion

    #region Methods UI
    /// <summary>
    /// <para>Open Opciones Menu</para>
    /// </summary>
    public void ClickOptions()// Open Opciones Menu
    {
        UpdateColorVol(ManagerSave._volG);
        panelOptions.SetActive(true);
    }

    /// <summary>
    /// <para>Close Opcions Menu</para>
    /// </summary>
    public void CloseOptions()// Close Opcions Menu
    {
        panelOptions.SetActive(false);
    }

    /// <summary>
    /// <para>Click in 1 Desk.</para>
    /// </summary>
    public void OnOpenDesk01()// Click in 1 Desk
    {
        switch (tempLangDesk01)
        {
            case 0:
                OpenPanel(2);
                break;

            case 1:
                OpenPanel(2);
                break;

            case 2:
                OpenPanel(2);
                break;

            case 3:
                OpenPanel(2);
                break;

            case 4:
                OpenPanel(2);
                break;

            case 5:
                OpenPanel(2);
                break;

            case 6:
                OpenPanel(2);
                break;

            case 7:
                OpenPanel(2);
                break;

            case 8:
                OpenPanel(2);
                break;

            default:
                Debug.Log("[Error] OpenDesk 1");
                break;
        }
    }

    /// <summary>
    /// <para>Click in 2 Desk.</para>
    /// </summary>
    public void OnOpenDesk02()// Click in 2 Desk
    {
        switch (tempLangDesk02)
        {
            case 0:
                OpenPanel(2);
                break;

            case 1:
                OpenPanel(2);
                break;

            case 2:
                OpenPanel(2);
                break;

            case 3:
                OpenPanel(2);
                break;

            case 4:
                OpenPanel(2);
                break;

            case 5:
                OpenPanel(2);
                break;

            case 6:
                OpenPanel(2);
                break;

            case 7:
                OpenPanel(2);
                break;

            case 8:
                OpenPanel(2);
                break;

            default:
                Debug.Log("[Error] OpenDesk 1");
                break;
        }
    }

    /// <summary>
    /// <para>Click in 3 Desk.</para>
    /// </summary>
    public void OnOpenDesk03()// Click in 3 Desk
    {
        switch (tempLangDesk03)
        {
            case 0:
                OpenPanel(2);
                break;

            case 1:
                OpenPanel(2);
                break;

            case 2:
                OpenPanel(2);
                break;

            case 3:
                OpenPanel(2);
                break;

            case 4:
                OpenPanel(2);
                break;

            case 5:
                OpenPanel(2);
                break;

            case 6:
                OpenPanel(2);
                break;

            case 7:
                OpenPanel(2);
                break;

            case 8:
                OpenPanel(2);
                break;

            default:
                Debug.Log("[Error] OpenDesk 1");
                break;
        }
    }

    /// <summary>
    /// <para>Click in 4 Desk.</para>
    /// </summary>
    public void OnOpenDesk04()// Click in 4 Desk
    {
        switch (tempLangDesk04)
        {
            case 0:
                OpenPanel(2);
                break;

            case 1:
                OpenPanel(2);
                break;

            case 2:
                OpenPanel(2);
                break;

            case 3:
                OpenPanel(2);
                break;

            case 4:
                OpenPanel(2);
                break;

            case 5:
                OpenPanel(2);
                break;

            case 6:
                OpenPanel(2);
                break;

            case 7:
                OpenPanel(2);
                break;

            case 8:
                OpenPanel(2);
                break;

            default:
                Debug.Log("[Error] OpenDesk 1");
                break;
        }
    }

    #region Methods Options
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
    #endregion

    #region Funcionality
    /// <summary>
    /// <para>Active Desk in Scene.</para>
    /// </summary>
    /// <param name="i">Param Desk</param>
    private void ActiveDesk(int i)// Active Desk in Scene
    {
        if (auxShuffle == 1)
        {
            switch (shuffle)
            {
                case 0:
                    imgDesk1.GetComponent<Image>().sprite = imgArray[0];
                    tempLangDesk01 = 0;
                    break;

                case 1:
                    imgDesk1.GetComponent<Image>().sprite = imgArray[1];
                    tempLangDesk01 = 1;
                    break;

                case 2:
                    imgDesk1.GetComponent<Image>().sprite = imgArray[2];
                    tempLangDesk01 = 2;
                    break;

                case 3:
                    imgDesk1.GetComponent<Image>().sprite = imgArray[3];
                    tempLangDesk01 = 3;
                    break;

                case 4:
                    imgDesk1.GetComponent<Image>().sprite = imgArray[4];
                    tempLangDesk01 = 4;
                    break;

                case 5:
                    imgDesk1.GetComponent<Image>().sprite = imgArray[5];
                    tempLangDesk01 = 5;
                    break;

                case 6:
                    imgDesk1.GetComponent<Image>().sprite = imgArray[6];
                    tempLangDesk01 = 6;
                    break;

                case 7:
                    imgDesk1.GetComponent<Image>().sprite = imgArray[7];
                    tempLangDesk01 = 7;
                    break;

                case 8:
                    imgDesk1.GetComponent<Image>().sprite = imgArray[8];
                    tempLangDesk01 = 8;
                    break;

                default:
                    shuffle = Random.Range(0, 8);
                    break;
            }
        }
        if (auxShuffle == 2)
        {
            switch (shuffle)
            {
                case 0:
                    imgDesk2.GetComponent<Image>().sprite = imgArray[0];
                    tempLangDesk02 = 0;
                    break;

                case 1:
                    imgDesk2.GetComponent<Image>().sprite = imgArray[1];
                    tempLangDesk02 = 1;
                    break;

                case 2:
                    imgDesk2.GetComponent<Image>().sprite = imgArray[2];
                    tempLangDesk02 = 2;
                    break;

                case 3:
                    imgDesk2.GetComponent<Image>().sprite = imgArray[3];
                    tempLangDesk02 = 3;
                    break;

                case 4:
                    imgDesk2.GetComponent<Image>().sprite = imgArray[4];
                    tempLangDesk02 = 4;
                    break;

                case 5:
                    imgDesk2.GetComponent<Image>().sprite = imgArray[5];
                    tempLangDesk02 = 5;
                    break;

                case 6:
                    imgDesk2.GetComponent<Image>().sprite = imgArray[6];
                    tempLangDesk02 = 6;
                    break;

                case 7:
                    imgDesk2.GetComponent<Image>().sprite = imgArray[7];
                    tempLangDesk02 = 7;
                    break;

                case 8:
                    imgDesk2.GetComponent<Image>().sprite = imgArray[8];
                    tempLangDesk02 = 8;
                    break;

                default:
                    shuffle = Random.Range(0, 8);
                    break;
            }
        }
        if (auxShuffle == 3)
        {
            switch (shuffle)
            {
                case 0:
                    imgDesk3.GetComponent<Image>().sprite = imgArray[0];
                    tempLangDesk03 = 0;
                    break;

                case 1:
                    imgDesk3.GetComponent<Image>().sprite = imgArray[1];
                    tempLangDesk03 = 1;
                    break;

                case 2:
                    imgDesk3.GetComponent<Image>().sprite = imgArray[2];
                    tempLangDesk03 = 2;
                    break;

                case 3:
                    imgDesk3.GetComponent<Image>().sprite = imgArray[3];
                    tempLangDesk03 = 3;
                    break;

                case 4:
                    imgDesk3.GetComponent<Image>().sprite = imgArray[4];
                    tempLangDesk03 = 4;
                    break;

                case 5:
                    imgDesk3.GetComponent<Image>().sprite = imgArray[5];
                    tempLangDesk03 = 5;
                    break;

                case 6:
                    imgDesk3.GetComponent<Image>().sprite = imgArray[6];
                    tempLangDesk03 = 6;
                    break;

                case 7:
                    imgDesk3.GetComponent<Image>().sprite = imgArray[7];
                    tempLangDesk03 = 7;
                    break;

                case 8:
                    imgDesk3.GetComponent<Image>().sprite = imgArray[8];
                    tempLangDesk03 = 8;
                    break;

                default:
                    shuffle = Random.Range(0, 8);
                    break;
            }
        }
        if (auxShuffle == 4)
        {
            switch (shuffle)
            {
                case 0:
                    imgDesk4.GetComponent<Image>().sprite = imgArray[0];
                    tempLangDesk04 = 0;
                    break;

                case 1:
                    imgDesk4.GetComponent<Image>().sprite = imgArray[1];
                    tempLangDesk04 = 1;
                    break;

                case 2:
                    imgDesk4.GetComponent<Image>().sprite = imgArray[2];
                    tempLangDesk04 = 2;
                    break;

                case 3:
                    imgDesk4.GetComponent<Image>().sprite = imgArray[3];
                    tempLangDesk04 = 3;
                    break;

                case 4:
                    imgDesk4.GetComponent<Image>().sprite = imgArray[4];
                    tempLangDesk04 = 4;
                    break;

                case 5:
                    imgDesk4.GetComponent<Image>().sprite = imgArray[5];
                    tempLangDesk04 = 5;
                    break;

                case 6:
                    imgDesk4.GetComponent<Image>().sprite = imgArray[6];
                    tempLangDesk04 = 6;
                    break;

                case 7:
                    imgDesk4.GetComponent<Image>().sprite = imgArray[7];
                    tempLangDesk04 = 7;
                    break;

                case 8:
                    imgDesk4.GetComponent<Image>().sprite = imgArray[8];
                    tempLangDesk04 = 8;
                    break;

                default:
                    shuffle = Random.Range(0, 8);
                    break;
            }
        }
    }

    /// <summary>
    /// <para>Close all panels and Open "i" Specific panel.</para>
    /// </summary>
    /// <param name="i">Open panel</param>
    private void OpenPanel(int i)// Close all panels and Open "i" Specific panel
    {
        if (i == 1)
        {
            panelSelection.SetActive(true);
            panelGame.SetActive(false);
            panelOptions.SetActive(false);
        }

        if (i == 2)
        {
            panelSelection.SetActive(false);
            panelGame.SetActive(true);
            panelOptions.SetActive(false);
        }

        if (i == 3)
        {
            panelOptions.SetActive(true);
        }
    }

    /// <summary>
    /// <para>Update color for image volume</para>
    /// </summary>
    /// <param name="i">int for color</param>
    private void UpdateColorVol(int i)// Update color for image volume
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
