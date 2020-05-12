using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Land_Select : MonoBehaviour
{
    
    public delegate void ButtonAction();
    public MyButtons[] buttonList;
    public int selectedButton = 0;

    public bool GotoForest = false;
    public bool GotoRuines = false;
    public bool GotoNML = false;

    private Turns_Select turned;

    public int timeToGo = 0;

    // Start is called before the first frame update
    void Start()
    {
        turned = GameObject.Find("GameManager").GetComponent<Turns_Select>();

        buttonList = new MyButtons[3];

        buttonList[2].image = GameObject.Find("Forest_Button").GetComponent<Image>();
        buttonList[2].image.color = Color.white;
        buttonList[2].action = ForestButtonAction;

        buttonList[1].image = GameObject.Find("Ruines_Button").GetComponent<Image>();
        buttonList[1].image.color = Color.white;
        buttonList[1].action = RuinesButtonAction;

        buttonList[0].image = GameObject.Find("NML_Button").GetComponent<Image>();
        buttonList[0].image.color = Color.white;
        buttonList[0].action = NMLButtonAction;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            MoveToNextButton();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveToPreviousButton();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            buttonList[selectedButton].action();
            timeToGo = turned.turnsnumber;
        }

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

    void ForestButtonAction()
    {
        Debug.Log("Forest Button Selected");
        GotoForest = true;
    }

    void RuinesButtonAction()
    {
        Debug.Log("Ruines Button Selected");
        GotoRuines = true;
    }

    void NMLButtonAction()
    {
        Debug.Log("NML Button Selected");
        GotoNML = true;
    }

    [System.Serializable]
    public struct MyButtons
    {
        public Image image;

        public ButtonAction action;
    }
}
