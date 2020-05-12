using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    private Gestion_Ressources _resources;

    private Day dayz;

    public float timeleft = 5;
    public Text time;
    public Canvas GameOverCanvas;

    public Text _defeat;

    // Start is called before the first frame update
    void Start()
    {
        //dayz = GameObject.Find("GameManager").GetComponent<Day>();
        _resources = GameObject.Find("GameManager").GetComponent<Gestion_Ressources>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOverCanvas.gameObject.activeInHierarchy)
        {
            Chrono();

            if (_resources.population == 0)
            {
                _defeat.text = " Vous n'avez plus de population. ";
            }
            
            if (_resources.material == 0)
            {
                _defeat.text = " Vous n'avez plus de materiaux. ";
            }

            if (_resources.vivres == 0)
            {
                _defeat.text = " Vous n'avez plus de vivres. ";
            }
        }



    }

    public void Chrono()
    {
        if (timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            time.text = "Restart dans : " + timeleft.ToString("00");
        }

        if (timeleft <= 0)
        {
            timeleft = 0;
          
            time.text = "Restart dans : " + timeleft.ToString("00");
        }
    }
}