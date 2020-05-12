using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turns_Select : MonoBehaviour
{

    public int turnsnumber = 0;
    public Text turnstext;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("One more turn");
            turnsnumber++;
            Debug.Log(turnsnumber);

            turnstext.text = "Nombre de tours : " + turnsnumber;

            if (turnsnumber >= 3)
            {
                turnsnumber = 3;
                turnstext.text = "Nombre de tours : " + turnsnumber;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("One less turn");
            turnsnumber--;
            Debug.Log(turnsnumber);

            turnstext.text = "Nombre de tours : " + turnsnumber;

            if (turnsnumber <= 1)
            {
                turnsnumber = 1;
                turnstext.text = "Nombre de tours : " + turnsnumber;
            }
        }
    }
}
