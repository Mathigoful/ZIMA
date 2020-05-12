using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalker : MonoBehaviour
{
    private Turns_Select turns;

    private Land_Select lands;

    private Gestion_Ressources resources;

    private Mathieu_Choice choises;

    private Stalker_Travel travel;

    private Liste_Stalkers _ls;

    public int health = 3;

    public bool rtogo;
    public bool gone = false;

    public bool forest = false;
    public bool ruines = false;
    public bool NML = false;

    public int turnedgone;
    public int saveturned;
    // Start is called before the first frame update
    void Start()
    {
        turns = GameObject.Find("GameManager").GetComponent<Turns_Select>();

        lands = GameObject.Find("GameManager").GetComponent<Land_Select>();

        resources = GameObject.Find("GameManager").GetComponent<Gestion_Ressources>();

        choises = GameObject.Find("GameManager").GetComponent<Mathieu_Choice>();

        travel = GameObject.Find("GameManager").GetComponent<Stalker_Travel>();

        _ls = GameObject.Find("GameManager").GetComponent<Liste_Stalkers>();

        turnedgone = 0;
        saveturned = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
}
