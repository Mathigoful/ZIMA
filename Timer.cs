using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    private Day dayz;

    public float timeleft = 30;
    public Text time;

    // Start is called before the first frame update
    void Start()
    {
        dayz = GameObject.Find("GameManager").GetComponent<Day>();
    }

    // Update is called once per frame
    void Update()
    {
        Chrono();
    }

    public void Chrono()
    {
        if (timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            time.text = "Temps restant : " + timeleft.ToString("00");
        }

        if (timeleft <= 0)
        {
            timeleft = 0;
            dayz.endDay = true;
            time.text = "Temps restant : " + timeleft.ToString("00");
        }
    }
}
