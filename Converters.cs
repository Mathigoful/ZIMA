using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Converters : MonoBehaviour
{

    public Image stalker;
    public Image confort;
    public Image forge;
    public Image grenier;

    public bool moreStalk;
    public bool moreConf;
    public bool moreForge;
    public bool moreGren;

    // Start is called before the first frame update
    void Start()
    {
        moreStalk = false;
        moreConf = false;
        moreForge = false;
        moreGren = false;

        stalker = GameObject.Find("Stalker_Button").GetComponent<Image>();
        stalker.color = Color.white;
        confort = GameObject.Find("Confort_Button").GetComponent<Image>();
        confort.color = Color.white;
        forge = GameObject.Find("Forge_Button").GetComponent<Image>();
        forge.color = Color.white;
        grenier = GameObject.Find("Grenier_Button").GetComponent<Image>();
        grenier.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine(StalkerCoro());
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            StartCoroutine(ConfortCoro());
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            StartCoroutine(ForgeCoro());
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            StartCoroutine(GrenierCoro());
        }
    }

    IEnumerator StalkerCoro()
    {
        Debug.Log("Create one Stalker");
        stalker.color = Color.red;
        moreStalk = true;
        yield return new WaitForSeconds(0.2f);
        stalker.color = Color.white;
    }

    IEnumerator ConfortCoro()
    {
        Debug.Log("Ameliorate Confort");
        confort.color = Color.red;
        moreConf = true;
        yield return new WaitForSeconds(0.2f);
        confort.color = Color.white;
    }

    IEnumerator ForgeCoro()
    {
        Debug.Log("Ameliorate Forge");
        forge.color = Color.red;
        moreForge = true;
        yield return new WaitForSeconds(0.2f);
        forge.color = Color.white;
    }

    IEnumerator GrenierCoro()
    {
        Debug.Log("Ameliorate Grenier");
        grenier.color = Color.red;
        moreGren = true;
        yield return new WaitForSeconds(0.2f);
        grenier.color = Color.white;
    }
}
