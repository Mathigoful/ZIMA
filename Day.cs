using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day : MonoBehaviour
{
    public bool endDay;
    public int day = 1;
    public Text daypast;

    private Timer timer;
    private Mathieu_Choice choices;
    private Turns_Select turnes;

    private Liste_Stalkers _sl;
    private Gestion_Ressources _ressources;
    private Stalkers_GetRessources _GetIt;

    private J_Choice_Result _JCVD;

    public GameObject FillMat; public GameObject FillPop; public GameObject FillRes;


    public float fillMat; public float fillPop; public float fillRes;

    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("GameManager").GetComponent<Timer>();
        choices = GameObject.Find("GameManager").GetComponent<Mathieu_Choice>();
        turnes = GameObject.Find("GameManager").GetComponent<Turns_Select>();
        _sl = GameObject.Find("GameManager").GetComponent<Liste_Stalkers>();
        _ressources = GameObject.Find("GameManager").GetComponent<Gestion_Ressources>();

        _GetIt = GameObject.Find("GameManager").GetComponent<Stalkers_GetRessources>();

        _JCVD = GameObject.Find("GameManager").GetComponent<J_Choice_Result>();

        daypast.text = "Jour " + day;
    }

    // Update is called once per frame
    void Update()
    {
        Daypast();
    }

    void Daypast()
    {

        if (timer.timeleft == 0)
        {
            
            _ressources.vivres--;
            _ressources.material--;
            _ressources.population--;

            fillMat = 0.1f;
            FillMat.transform.localScale -= new Vector3(fillMat, 0f);
            fillPop = 0.1f;
            FillPop.transform.localScale -= new Vector3(fillPop, 0f);
            fillRes = 0.1f;
            FillRes.transform.localScale -= new Vector3(fillRes, 0f);

            day++;
            turnes.turnsnumber = 0;
            Debug.Log("Day = " + day);
            daypast.text = "Jour " + day;
            endDay = false;
            timer.timeleft = 30;

            foreach (GameObject stalker in _sl.stalkerlist)
            {
                if (stalker.GetComponent<Stalker>().turnedgone > 0)
                {
                    stalker.GetComponent<Stalker>().turnedgone--;
                }

                if (stalker.GetComponent<Stalker>().turnedgone == 0)
                {
                    stalker.GetComponent<Stalker>().rtogo = true;
                    stalker.GetComponent<Stalker>().gone = false;
                    _GetIt.GetRessourcesForest();
                    _GetIt.GetRessourcesRuines();
                    _GetIt.GetRessourcesNML();
                    stalker.GetComponent<Stalker>().forest = false;
                    stalker.GetComponent<Stalker>().ruines = false;
                    stalker.GetComponent<Stalker>().NML = false;
                }
                
            }

            _JCVD.SelectTheQuestion();
        }

        if (endDay == true)
        {
            day++;
            turnes.turnsnumber = 0;
            Debug.Log("Turns Selected = " + turnes.turnsnumber);
            Debug.Log("Day = " + day);
            daypast.text = "Jour " + day;
            endDay = false;
            timer.timeleft = 30;

            foreach (GameObject stalker in _sl.stalkerlist)
            {
                if (stalker.GetComponent<Stalker>().turnedgone > 0)
                {
                    stalker.GetComponent<Stalker>().turnedgone--;
                }

                if (stalker.GetComponent<Stalker>().turnedgone == 0)
                {
                    stalker.GetComponent<Stalker>().rtogo = true;
                    stalker.GetComponent<Stalker>().gone = false;
                    _GetIt.GetRessourcesForest();
                    _GetIt.GetRessourcesRuines();
                    _GetIt.GetRessourcesNML();
                    stalker.GetComponent<Stalker>().forest = false;
                    stalker.GetComponent<Stalker>().ruines = false;
                    stalker.GetComponent<Stalker>().NML = false;
                }
            }
        }
    }
}
