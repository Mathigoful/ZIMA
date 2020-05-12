using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalker_Travel : MonoBehaviour
{
    private Turns_Select turns;

    private Land_Select lands;

    private Gestion_Ressources resources;

    private Mathieu_Choice choises;

    private Day dayz;

    private Liste_Stalkers _ls;

    // Start is called before the first frame update
    void Start()
    {
        turns = GameObject.Find("GameManager").GetComponent<Turns_Select>();

        lands = GameObject.Find("GameManager").GetComponent<Land_Select>();

        resources = GameObject.Find("GameManager").GetComponent<Gestion_Ressources>();

        choises = GameObject.Find("GameManager").GetComponent<Mathieu_Choice>();

        dayz = GameObject.Find("GameManager").GetComponent<Day>();

        _ls = GameObject.Find("GameManager").GetComponent<Liste_Stalkers>();

        foreach (GameObject stalker in _ls.stalkerlist)
        {
            stalker.GetComponent<Stalker>().rtogo = true;
            Debug.Log("Stalkers Ready to Go ");
        }
}

    // Update is called once per frame
    void Update()
    {
        TraveltoForest();
        TraveltoRuines();
        TraveltoNML();
    }

    void TraveltoForest()
    {
        if (lands.GotoForest == true && resources.stalker > 0)
        {
            for (int i = 0; i < _ls.stalkerlist.Length; i++)
            {
                if (_ls.stalkerlist[i].GetComponent<Stalker>().gone == false)
                {
                    _ls.stalkerlist[i].GetComponent<Stalker>().rtogo = false;
                    _ls.stalkerlist[i].GetComponent<Stalker>().gone = true;
                    _ls.stalkerlist[i].GetComponent<Stalker>().forest = true;
                    _ls.stalkerlist[i].GetComponent<Stalker>().turnedgone = turns.turnsnumber;
                    _ls.stalkerlist[i].GetComponent<Stalker>().saveturned = turns.turnsnumber;

                    resources.stalker--;
                    resources.stalk.text = " Stalkers : " + resources.stalker;
                    lands.GotoForest = false;

                    turns.turnsnumber = 0;
                    turns.turnstext.text = "Nombre de tours : " + turns.turnsnumber;

                    return;
                }
            }
            
            /*foreach (GameObject stalker in _ls.stalkerlist)
            {
                if (stalker.GetComponent<Stalker>().gone == false)
                {
                    stalker.GetComponent<Stalker>().rtogo = false;
                    stalker.GetComponent<Stalker>().gone = true;
                    stalker.GetComponent<Stalker>().forest = true;
                    /*_ls.stalkerlist[0].GetComponent<Stalker>().rtogo = false;
                    _ls.stalkerlist[0].GetComponent<Stalker>().gone = true;
                    _ls.stalkerlist[0].GetComponent<Stalker>().forest = true;

                    /*stalker.GetComponent<Stalker>().rtogo = false;
                    stalker.GetComponent<Stalker>().gone = true;
                    stalker.GetComponent<Stalker>().forest = true;
                }
            }*/
        }
    }

    void TraveltoRuines()
    {
        if (lands.GotoRuines == true && resources.stalker > 0)
        {
            for (int i = 0; i < _ls.stalkerlist.Length; i++)
            {
                if (_ls.stalkerlist[i].GetComponent<Stalker>().gone == false)
                {
                    _ls.stalkerlist[i].GetComponent<Stalker>().rtogo = false;
                    _ls.stalkerlist[i].GetComponent<Stalker>().gone = true;
                    _ls.stalkerlist[i].GetComponent<Stalker>().ruines = true;
                    _ls.stalkerlist[i].GetComponent<Stalker>().turnedgone = turns.turnsnumber;
                    _ls.stalkerlist[i].GetComponent<Stalker>().saveturned = turns.turnsnumber;

                    resources.stalker--;
                    resources.stalk.text = " Stalkers : " + resources.stalker;
                    lands.GotoRuines = false;

                    turns.turnsnumber = 0;
                    turns.turnstext.text = "Nombre de tours : " + turns.turnsnumber;

                    return;
                }
            }
        }
    }

    void TraveltoNML()
    {
        if (lands.GotoNML == true && resources.stalker > 0)
        {
            for (int i = 0; i < _ls.stalkerlist.Length; i++)
            {
                if (_ls.stalkerlist[i].GetComponent<Stalker>().gone == false)
                {
                    _ls.stalkerlist[i].GetComponent<Stalker>().rtogo = false;
                    _ls.stalkerlist[i].GetComponent<Stalker>().gone = true;
                    _ls.stalkerlist[i].GetComponent<Stalker>().NML = true;
                    _ls.stalkerlist[i].GetComponent<Stalker>().turnedgone = turns.turnsnumber;
                    _ls.stalkerlist[i].GetComponent<Stalker>().saveturned = turns.turnsnumber;

                    resources.stalker--;
                    resources.stalk.text = " Stalkers : " + resources.stalker;
                    lands.GotoNML = false;

                    turns.turnsnumber = 0;
                    turns.turnstext.text = "Nombre de tours : " + turns.turnsnumber;

                    return;
                }
            }
        }
    }
}
