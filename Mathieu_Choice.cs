using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mathieu_Choice : MonoBehaviour
{


    public delegate void ButtonAction();
    public MyButtons[] buttonList;
    public int selectedButton = 0;

    private Day dayz;
    private J_Choice_Result test;

    public J_Drains Drain;
    private Mat_Bar MBar;
    private Deck2List Andeck;
    private Gestion_Ressources _ressources;


    public GameObject FillMat; public GameObject FillPop; public GameObject FillRes;


    public float fillMat; public float fillPop; public float fillRes;


    // Start is called before the first frame update
    void Start()
    {
        buttonList = new MyButtons[2];
        buttonList[1].image = GameObject.Find("Left_Answer").GetComponent<Image>();
        buttonList[1].image.color = Color.white;
        buttonList[1].action = LeftButtonAction;

        buttonList[0].image = GameObject.Find("Right_Answer").GetComponent<Image>();
        buttonList[0].image.color = Color.white;
        buttonList[0].action = RightButtonAction;

        dayz = GameObject.Find("GameManager").GetComponent<Day>();
        test = GameObject.Find("GameManager").GetComponent<J_Choice_Result>();

        Drain = GameObject.Find("GameManager").GetComponent<J_Drains>();
        Andeck = GameObject.Find("GameManager").GetComponent<Deck2List>();

        MBar = GameObject.Find("GameManager").GetComponent<Mat_Bar>();
        _ressources = GameObject.Find("GameManager").GetComponent<Gestion_Ressources>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveToNextButton();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveToPreviousButton();
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            buttonList[selectedButton].action();
        }

        Drain.Drainage(buttonList[selectedButton].image.transform);
        Drain.Bonus(buttonList[selectedButton].image.transform);

    }

    void MoveToNextButton()
    {
        buttonList[selectedButton].image.color = Color.white;
        selectedButton++;
        if (selectedButton >= buttonList.Length)
        {
            selectedButton = 0;
        }
        buttonList[selectedButton].image.color = Color.green;
    }

    void MoveToPreviousButton()
    {
        buttonList[selectedButton].image.color = Color.white;
        selectedButton--;
        if (selectedButton < 0)
        {
            selectedButton = (buttonList.Length - 1);
        }
        buttonList[selectedButton].image.color = Color.green;
    }

    void LeftButtonAction()
    {
        #region L_Drain

        if (Drain._Rds[0] == true)
        {
            fillMat = 0.1f;
            FillMat.transform.localScale -= new Vector3(fillMat, 0f);
            _ressources.material--;
            Drain.RDM_1.SetActive(false);
        }

        if (Drain._Rds[1] == true)
        {
            fillMat = 0.2f;
            FillMat.transform.localScale -= new Vector3(fillMat, 0f);
            _ressources.material = _ressources.material - 2;
            Drain.RDM_2.SetActive(false);
        }

        if (Drain._Rds[2] == true)
        {
            fillMat = 0.3f;
            FillMat.transform.localScale -= new Vector3(fillMat, 0f);
            _ressources.material = _ressources.material - 3;
            Drain.RDM_3.SetActive(false);
        }

        if (Drain._Rds[3] == true)
        {
            fillPop = 0.1f;
            FillPop.transform.localScale -= new Vector3(fillPop, 0f);
            _ressources.population--;
            Drain.RDP_1.SetActive(false);
        }

        if (Drain._Rds[4] == true)
        {
            fillPop = 0.2f;
            FillPop.transform.localScale -= new Vector3(fillPop, 0f);
            _ressources.population = _ressources.population - 2;
            Drain.RDP_2.SetActive(false);
        }

        if (Drain._Rds[5] == true)
        {
            fillPop = 0.3f;
            FillPop.transform.localScale -= new Vector3(fillPop, 0f);
            _ressources.population = _ressources.population - 3;
            Drain.RDP_3.SetActive(false);
        }

        if (Drain._Rds[6] == true)
        {
            fillRes = 0.1f;
            FillRes.transform.localScale -= new Vector3(fillRes, 0f);
            _ressources.vivres--;
            Drain.RDR_1.SetActive(false);
        }

        if (Drain._Rds[7] == true)
        {
            fillRes = 0.2f;
            FillRes.transform.localScale -= new Vector3(fillRes, 0f);
            _ressources.vivres = _ressources.vivres - 2;
            Drain.RDR_2.SetActive(false);
        }

        if (Drain._Rds[8] == true)
        {
            fillRes = 0.3f;
            FillRes.transform.localScale -= new Vector3(fillRes, 0f);
            _ressources.vivres = _ressources.vivres - 3;
            Drain.RDR_3.SetActive(false);
        }
        #endregion

        #region L_Bonus

        if (Drain._Bds[0] == true)
        {
            fillMat = 0.1f;
            FillMat.transform.localScale += new Vector3(fillMat, 0f);
            _ressources.material++;
            Drain.BDM_1.SetActive(false);
        }

        if (Drain._Bds[1] == true)
        {
            fillMat = 0.2f;
            FillMat.transform.localScale += new Vector3(fillMat, 0f);
            _ressources.material = _ressources.material +2;
            Drain.BDM_2.SetActive(false);
        }

        if (Drain._Bds[2] == true)
        {
            fillMat = 0.3f;
            FillMat.transform.localScale += new Vector3(fillMat, 0f);
            _ressources.material = _ressources.material + 3;
            Drain.BDM_3.SetActive(false);
        }

        if (Drain._Bds[3] == true)
        {
            fillPop = 0.1f;
            FillPop.transform.localScale += new Vector3(fillPop, 0f);
            _ressources.population++;
            Drain.BDP_1.SetActive(false);
        }

        if (Drain._Bds[4] == true)
        {
            fillPop = 0.2f;
            FillPop.transform.localScale += new Vector3(fillPop, 0f);
            _ressources.population = _ressources.population + 2;
            Drain.BDP_2.SetActive(false);
        }

        if (Drain._Bds[5] == true)
        {
            fillPop = 0.3f;
            FillPop.transform.localScale += new Vector3(fillPop, 0f);
            _ressources.population = _ressources.population + 3;
            Drain.BDP_3.SetActive(false);
        }

        if (Drain._Bds[6] == true)
        {
            fillRes = 0.1f;
            FillRes.transform.localScale += new Vector3(fillRes, 0f);
            _ressources.vivres++;
            Drain.BDR_1.SetActive(false);
        }

        if (Drain._Bds[7] == true)
        {
            fillRes = 0.2f;
            FillRes.transform.localScale += new Vector3(fillRes, 0f);
            _ressources.vivres = _ressources.vivres + 2;
            Drain.BDR_2.SetActive(false);
        }

        if (Drain._Bds[8] == true)
        {
            fillRes = 0.3f;
            FillRes.transform.localScale += new Vector3(fillRes, 0f);
            _ressources.vivres = _ressources.vivres + 3;
            Drain.BDR_3.SetActive(false);
        }

        #endregion

        /*Debug.Log("Left Button Selected");
        dayz.endDay = true;
        Debug.Log("End Day" + dayz.endDay);
        //mettre l'aleatoire de la question est du perso*/


        if (dayz.day < 10)//test.enabled == true)
        {
            //test.HideIt(test.ActiveQuestion);
            //Debug.Log("Active Question : " + test.ActiveQuestion);
            //Debug.Log("Left Button Selected");
            dayz.endDay = true;
            Debug.Log("End Day" + dayz.endDay);

            test.SelectTheQuestion();
            
            //Debug.Log("Active Question : " + test.ActiveQuestion);
        }
        else
        {
            //test.HideIt(test.ActiveQuestion);
            //Debug.Log("Active Question : " + test.ActiveQuestion);
            //Debug.Log("Left Button Selected");
            dayz.endDay = true;
            Debug.Log("End Day" + dayz.endDay);

            test.SelectTheQuestion();
            //Debug.Log("Active Question : " + test.ActiveQuestion);
        }

        //Drain.Drainage(buttonList[selectedButton].image.transform);

    }

    void RightButtonAction()
    {
        #region R_Drain

        if (Drain._Rds[0] == true)
        {
            fillMat = 0.1f;
            FillMat.transform.localScale -= new Vector3(fillMat, 0f);
            _ressources.material--;
            Drain.RDM_1.SetActive(false);
        }

        if (Drain._Rds[1] == true)
        {
            fillMat = 0.2f;
            FillMat.transform.localScale -= new Vector3(fillMat, 0f);
            _ressources.material = _ressources.material - 2;
            Drain.RDM_2.SetActive(false);
        }

        if (Drain._Rds[2] == true)
        {
            fillMat = 0.3f;
            FillMat.transform.localScale -= new Vector3(fillMat, 0f);
            _ressources.material = _ressources.material - 3;
            Drain.RDM_3.SetActive(false);
        }

        if (Drain._Rds[3] == true)
        {
            fillPop = 0.1f;
            FillPop.transform.localScale -= new Vector3(fillPop, 0f);
            _ressources.population--;
            Drain.RDP_1.SetActive(false);
        }

        if (Drain._Rds[4] == true)
        {
            fillPop = 0.2f;
            FillPop.transform.localScale -= new Vector3(fillPop, 0f);
            _ressources.population = _ressources.population - 2;
            Drain.RDP_2.SetActive(false);
        }

        if (Drain._Rds[5] == true)
        {
            fillPop = 0.3f;
            FillPop.transform.localScale -= new Vector3(fillPop, 0f);
            _ressources.population = _ressources.population - 3;
            Drain.RDP_3.SetActive(false);
        }

        if (Drain._Rds[6] == true)
        {
            fillRes = 0.1f;
            FillRes.transform.localScale -= new Vector3(fillRes, 0f);
            _ressources.vivres--;
            Drain.RDR_1.SetActive(false);
        }

        if (Drain._Rds[7] == true)
        {
            fillRes = 0.2f;
            FillRes.transform.localScale -= new Vector3(fillRes, 0f);
            _ressources.vivres = _ressources.vivres - 2;
            Drain.RDR_2.SetActive(false);
        }

        if (Drain._Rds[8] == true)
        {
            fillRes = 0.3f;
            FillRes.transform.localScale -= new Vector3(fillRes, 0f);
            _ressources.vivres = _ressources.vivres - 3;
            Drain.RDR_3.SetActive(false);
        }
        #endregion

        #region R_Bonus

        if (Drain._Bds[0] == true)
        {
            fillMat = 0.1f;
            FillMat.transform.localScale += new Vector3(fillMat, 0f);
            _ressources.material++;
            Drain.BDM_1.SetActive(false);
        }

        if (Drain._Bds[1] == true)
        {
            fillMat = 0.2f;
            FillMat.transform.localScale += new Vector3(fillMat, 0f);
            _ressources.material = _ressources.material + 2;
            Drain.BDM_2.SetActive(false);
        }

        if (Drain._Bds[2] == true)
        {
            fillMat = 0.3f;
            FillMat.transform.localScale += new Vector3(fillMat, 0f);
            _ressources.material = _ressources.material + 3;
            Drain.BDM_3.SetActive(false);
        }

        if (Drain._Bds[3] == true)
        {
            fillPop = 0.1f;
            FillPop.transform.localScale += new Vector3(fillPop, 0f);
            _ressources.population++;
            Drain.BDP_1.SetActive(false);
        }

        if (Drain._Bds[4] == true)
        {
            fillPop = 0.2f;
            FillPop.transform.localScale += new Vector3(fillPop, 0f);
            _ressources.population = _ressources.population + 2;
            Drain.BDP_2.SetActive(false);
        }

        if (Drain._Bds[5] == true)
        {
            fillPop = 0.3f;
            FillPop.transform.localScale += new Vector3(fillPop, 0f);
            _ressources.population = _ressources.population + 3;
            Drain.BDP_3.SetActive(false);
        }

        if (Drain._Bds[6] == true)
        {
            fillRes = 0.1f;
            FillRes.transform.localScale += new Vector3(fillRes, 0f);
            _ressources.vivres++;
            Drain.BDR_1.SetActive(false);
        }

        if (Drain._Bds[7] == true)
        {
            fillRes = 0.2f;
            FillRes.transform.localScale += new Vector3(fillRes, 0f);
            _ressources.vivres = _ressources.vivres + 2;
            Drain.BDR_2.SetActive(false);
        }

        if (Drain._Bds[8] == true)
        {
            fillRes = 0.3f;
            FillRes.transform.localScale += new Vector3(fillRes, 0f);
            _ressources.vivres = _ressources.vivres + 3;
            Drain.BDR_3.SetActive(false);
        }

        #endregion


        /*Debug.Log("Right Button Selected");
        dayz.endDay = true;
        Debug.Log("End Day = " + dayz.endDay);
        //mettre l'aleatoire de la question est du perso*/

        if (dayz.day < 10)//test.enabled == true)
        {
            //test.HideIt(test.ActiveQuestion);
            //Debug.Log("Active Question : " + test.ActiveQuestion);
            //Debug.Log("Right Button Selected");
            dayz.endDay = true;
            Debug.Log("End Day" + dayz.endDay);

            test.SelectTheQuestion();
            //Debug.Log("Active Question : " + test.ActiveQuestion);
        }
        else
        {
            //test.HideIt(test.ActiveQuestion);
            //Debug.Log("Active Question : " + test.ActiveQuestion);
            //Debug.Log("Right Button Selected");
            dayz.endDay = true;
            Debug.Log("End Day" + dayz.endDay);

            test.SelectTheQuestion();
            //Debug.Log("Active Question : " + test.ActiveQuestion);
        }
    }

    [System.Serializable]
    public struct MyButtons
    {
        public Image image;

        public ButtonAction action;
    }
}
