using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalkers_GetRessources : MonoBehaviour
{
    private Turns_Select turns;

    private Land_Select lands;

    private Gestion_Ressources resources;

    private Mathieu_Choice choises;

    private Stalker_Travel travel;

    private Day dayz;
    private Timer timer;

    private Liste_Stalkers _sl;

    private int selected;
    public int[] valuelist;

    public GameObject FillMat; public GameObject FillPop; public GameObject FillRes;

    public float fillMat; public float fillPop; public float fillRes;

    // Start is called before the first frame update
    void Start()
    {
        turns = GameObject.Find("GameManager").GetComponent<Turns_Select>();

        lands = GameObject.Find("GameManager").GetComponent<Land_Select>();

        resources = GameObject.Find("GameManager").GetComponent<Gestion_Ressources>();

        choises = GameObject.Find("GameManager").GetComponent<Mathieu_Choice>();

        travel = GameObject.Find("GameManager").GetComponent<Stalker_Travel>();

        dayz = GameObject.Find("GameManager").GetComponent<Day>();

        timer = GameObject.Find("GameManager").GetComponent<Timer>();

        _sl = GameObject.Find("GameManager").GetComponent<Liste_Stalkers>();

        valuelist = new int[9];
    }

    // Update is called once per frame
    void Update()
    {

    }

   public void GetRessourcesForest()
    {
        foreach (GameObject stalker in _sl.stalkerlist)
        {
             if (stalker.GetComponent<Stalker>().rtogo == true && stalker.GetComponent<Stalker>().forest == true)
             {
                if (stalker.GetComponent<Stalker>().saveturned == 1)
                {
                    Debug.Log("Get +1 Vivre & Get +1 Stalker");
                    resources.vivres = resources.vivres + 1;
                    resources.stalker = resources.stalker + 1;
                    fillRes = 0.1f;
                    FillRes.transform.localScale += new Vector3(fillRes, 0f);
                    stalker.GetComponent<Stalker>().rtogo = false;
                    resources.stalk.text = " Stalkers : " + resources.stalker;

                    valuelist[0] = Random.Range(1, 10);
                    Debug.Log("Value est égal à " + valuelist[0]);
                    if (valuelist[0] > 7 && valuelist[0] <= 10)
                    {
                        stalker.GetComponent<Stalker>().health--;
                        Debug.Log("Stalker -1PV T1");

                        if (stalker.GetComponent<Stalker>().health == 0)
                        {
                            resources.stalker--;
                            Debug.Log("Stalker is Dead");
                            resources.stalk.text = " Stalkers : " + resources.stalker;
                            resources.stalking = false;
                            //stalker.GetComponent<Stalker>().health = 3;
                        }
                    }
                    else

                    return;
                }

                if (stalker.GetComponent<Stalker>().saveturned == 2)
                {
                    Debug.Log("Get +2 Vivres & Get +1 Stalker");
                    resources.vivres = resources.vivres + 2;
                    resources.stalker = resources.stalker + 1;
                    fillRes = 0.2f;
                    FillRes.transform.localScale += new Vector3(fillRes, 0f);
                    stalker.GetComponent<Stalker>().rtogo = false;
                    resources.stalk.text = " Stalkers : " + resources.stalker;

                    valuelist[1] = Random.Range(1, 5);
                    Debug.Log("Value est égal à " + valuelist[1]);
                    if (valuelist[1] > 3 && valuelist[1] <= 5)
                    {
                        stalker.GetComponent<Stalker>().health--;
                        Debug.Log("Stalker -1PV T2");

                        if (stalker.GetComponent<Stalker>().health == 0)
                        {
                            resources.stalker--;
                            Debug.Log("Stalker is Dead");
                            resources.stalk.text = " Stalkers : " + resources.stalker;
                            resources.stalking = false;
                            //stalker.GetComponent<Stalker>().health = 3;
                        }
                    }
                    else

                    return;
                }

                if (stalker.GetComponent<Stalker>().saveturned == 3)
                {
                    Debug.Log("Get +3 Vivres & Get +1 Stalker");
                    resources.vivres = resources.vivres + 3;
                    resources.stalker = resources.stalker + 1;
                    fillRes = 0.3f;
                    FillRes.transform.localScale += new Vector3(fillRes, 0f);
                    stalker.GetComponent<Stalker>().rtogo = false;
                    resources.stalk.text = " Stalkers : " + resources.stalker;

                    valuelist[2] = Random.Range(1, 3);
                    Debug.Log("Value est égal à " + valuelist[2]);
                    if (valuelist[2] >= 2)
                    {
                        stalker.GetComponent<Stalker>().health--;
                        Debug.Log("Stalker -1PV T3");

                        if (stalker.GetComponent<Stalker>().health == 0)
                        {
                            resources.stalker--;
                            Debug.Log("Stalker is Dead");
                            resources.stalk.text = " Stalkers : " + resources.stalker;
                            resources.stalking = false;
                            //stalker.GetComponent<Stalker>().health = 3;
                        }
                    }
                    else

                    return;
                }
             }
        }
    }

    public void GetRessourcesRuines()
    {
        foreach (GameObject stalker in _sl.stalkerlist)
        {
            if (stalker.GetComponent<Stalker>().rtogo == true && stalker.GetComponent<Stalker>().ruines == true)
            {
                if (stalker.GetComponent<Stalker>().saveturned == 1)
                {
                    Debug.Log("Get +1 Material & Get +1 Stalker");
                    resources.material = resources.material + 1;
                    resources.stalker = resources.stalker + 1;
                    fillMat = 0.1f;
                    FillMat.transform.localScale += new Vector3(fillMat, 0f);
                    stalker.GetComponent<Stalker>().rtogo = false;
                    resources.stalk.text = " Stalkers : " + resources.stalker;

                    valuelist[3] = Random.Range(1, 10);
                    Debug.Log("Value est égal à " + valuelist[3]);
                    if (valuelist[3] > 7 && valuelist[3] <= 10)
                    {
                        stalker.GetComponent<Stalker>().health--;
                        Debug.Log("Stalker -1PV T1");

                        if (stalker.GetComponent<Stalker>().health == 0)
                        {
                            resources.stalker--;
                            Debug.Log("Stalker is Dead");
                            resources.stalk.text = " Stalkers : " + resources.stalker;
                            resources.stalking = false;
                            //stalker.GetComponent<Stalker>().health = 3;
                        }
                    }
                    else

                    return;
                }

                if (stalker.GetComponent<Stalker>().saveturned == 2)
                {
                    Debug.Log("Get +2 Materials & Get +1 Stalker");
                    resources.material = resources.material + 2;
                    resources.stalker = resources.stalker + 1;
                    fillMat = 0.2f;
                    FillMat.transform.localScale += new Vector3(fillMat, 0f);
                    stalker.GetComponent<Stalker>().rtogo = false;
                    resources.stalk.text = " Stalkers : " + resources.stalker;

                    valuelist[4] = Random.Range(1, 5);
                    Debug.Log("Value est égal à " + valuelist[4]);
                    if (valuelist[4] > 3 && valuelist[4] <= 5)
                    {
                        stalker.GetComponent<Stalker>().health--;
                        Debug.Log("Stalker -1PV T2");

                        if (stalker.GetComponent<Stalker>().health == 0)
                        {
                            resources.stalker--;
                            Debug.Log("Stalker is Dead");
                            resources.stalk.text = " Stalkers : " + resources.stalker;
                            resources.stalking = false;
                            //stalker.GetComponent<Stalker>().health = 3;
                        }
                    }
                    else

                    return;
                }

                if (stalker.GetComponent<Stalker>().saveturned == 3)
                {
                    Debug.Log("Get +3 Materials & Get +1 Stalker");
                    resources.material = resources.material + 3;
                    resources.stalker = resources.stalker + 1;
                    fillMat = 0.3f;
                    FillMat.transform.localScale += new Vector3(fillMat, 0f);
                    stalker.GetComponent<Stalker>().rtogo = false;
                    resources.stalk.text = " Stalkers : " + resources.stalker;

                    valuelist[5] = Random.Range(1, 3);
                    Debug.Log("Value est égal à " + valuelist[5]);
                    if (valuelist[5] >= 2)
                    {
                        stalker.GetComponent<Stalker>().health--;
                        Debug.Log("Stalker -1PV T3");

                        if (stalker.GetComponent<Stalker>().health == 0)
                        {
                            resources.stalker--;
                            Debug.Log("Stalker is Dead");
                            resources.stalk.text = " Stalkers : " + resources.stalker;
                            resources.stalking = false;
                            //stalker.GetComponent<Stalker>().health = 3;
                        }
                    }
                    else

                    return;
                }
            }
        }
    }

    public void GetRessourcesNML()
    {
        foreach (GameObject stalker in _sl.stalkerlist)
        {
            if (stalker.GetComponent<Stalker>().rtogo == true && stalker.GetComponent<Stalker>().NML == true)
            {
                if (stalker.GetComponent<Stalker>().saveturned == 1)
                {
                    Debug.Log("Get +1 Pop & Get +1 Stalker");
                    resources.population = resources.population + 1;
                    resources.stalker = resources.stalker + 1;
                    fillPop = 0.1f;
                    FillPop.transform.localScale += new Vector3(fillPop, 0f);
                    stalker.GetComponent<Stalker>().rtogo = false;
                    resources.stalk.text = " Stalkers : " + resources.stalker;

                    valuelist[6] = Random.Range(1, 10);
                    Debug.Log("Value est égal à " + valuelist[6]);
                    if (valuelist[6] > 7 && valuelist[6] <= 10)
                    {
                        stalker.GetComponent<Stalker>().health--;
                        Debug.Log("Stalker -1PV T1");

                        if (stalker.GetComponent<Stalker>().health == 0)
                        {
                            resources.stalker--;
                            Debug.Log("Stalker is Dead");
                            resources.stalk.text = " Stalkers : " + resources.stalker;
                            resources.stalking = false;
                            //stalker.GetComponent<Stalker>().health = 3;
                        }
                    }
                    else

                    return;
                }

                if (stalker.GetComponent<Stalker>().saveturned == 2)
                {
                    Debug.Log("Get +2 Populations & Get +1 Stalker");
                    resources.population = resources.population + 2;
                    resources.stalker = resources.stalker + 1;
                    fillPop = 0.2f;
                    FillPop.transform.localScale += new Vector3(fillPop, 0f);
                    stalker.GetComponent<Stalker>().rtogo = false;
                    resources.stalk.text = " Stalkers : " + resources.stalker;

                    valuelist[7] = Random.Range(1, 5);
                    Debug.Log("Value est égal à " + valuelist[7]);
                    if (valuelist[7] > 3 && valuelist[7] <= 5)
                    {
                        stalker.GetComponent<Stalker>().health--;
                        Debug.Log("Stalker -1PV T2");

                        if (stalker.GetComponent<Stalker>().health == 0)
                        {
                            resources.stalker--;
                            Debug.Log("Stalker is Dead");
                            resources.stalk.text = " Stalkers : " + resources.stalker;
                            resources.stalking = false;
                            //stalker.GetComponent<Stalker>().health = 3;
                        }
                    }
                    else

                    return;
                }

                if (stalker.GetComponent<Stalker>().saveturned == 3)
                {
                    Debug.Log("Get +3 Populations & Get +1 Stalker");
                    resources.population = resources.population + 3;
                    resources.stalker = resources.stalker + 1;
                    fillPop = 0.3f;
                    FillPop.transform.localScale += new Vector3(fillPop, 0f);
                    stalker.GetComponent<Stalker>().rtogo = false;
                    resources.stalk.text = " Stalkers : " + resources.stalker;

                    valuelist[8] = Random.Range(1, 3);
                    Debug.Log("Value est égal à " + valuelist[8]);
                    if (valuelist[8] >= 2)
                    {
                        stalker.GetComponent<Stalker>().health--;
                        Debug.Log("Stalker -1PV T3");

                        if (stalker.GetComponent<Stalker>().health == 0)
                        {
                            resources.stalker--;
                            Debug.Log("Stalker is Dead");
                            resources.stalk.text = " Stalkers : " + resources.stalker;
                            resources.stalking = false;
                            //stalker.GetComponent<Stalker>().health = 3;
                        }
                    }
                    else

                    return;
                }
            }
        }
    }
}
