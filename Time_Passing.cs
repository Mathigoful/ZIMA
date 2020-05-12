using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Passing : MonoBehaviour
{
    private Turns_Select turns;

    private Land_Select lands;

    private Gestion_Ressources resources;

    private Mathieu_Choice choises;

    private Stalker_Travel travel;

    private Day dayz;
    // Start is called before the first frame update
    void Start()
    {
        turns = GameObject.Find("GameManager").GetComponent<Turns_Select>();

        lands = GameObject.Find("GameManager").GetComponent<Land_Select>();

        resources = GameObject.Find("GameManager").GetComponent<Gestion_Ressources>();

        choises = GameObject.Find("GameManager").GetComponent<Mathieu_Choice>();

        travel = GameObject.Find("GameManager").GetComponent<Stalker_Travel>();

        dayz = GameObject.Find("GameManager").GetComponent<Day>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
