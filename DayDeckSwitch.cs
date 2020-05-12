using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayDeckSwitch : MonoBehaviour
{
    private Day _dayValue;
    private J_Choice_Result _disableMe;
    private Deck2List _enableMe;

    // Start is called before the first frame update
    void Start()
    {
        _dayValue = GameObject.Find("GameManager").GetComponent<Day>();
        _disableMe = GameObject.Find("GameManager").GetComponent<J_Choice_Result>();
        _enableMe = GameObject.Find("GameManager").GetComponent<Deck2List>();
    }

    // Update is called once per frame
    void Update()
    {
        //SwitchDeck();
    }

    /*void SwitchDeck()
    {
        if (_dayValue.day == 10)
        {
            _disableMe.enabled = false;
            _enableMe.enabled = true;
        } 

    }

    void checkQuestionIsActive()
    {
        if (_disableMe.enabled == false)
        {
            _disableMe.HideIt(_disableMe.ActiveQuestion);
        }
    }*/
}
