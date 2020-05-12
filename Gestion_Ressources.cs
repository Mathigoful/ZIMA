using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gestion_Ressources : MonoBehaviour
{

    public GameObject FillMat; public GameObject FillPop; public GameObject FillRes;


    public float fillMat; public float fillPop; public float fillRes;

    public Canvas _c1;
    public Canvas _c2;

    public int stalker = 1;
    public int maxStalker = 4;
    public bool stalking;

    public int vivres = 5;
    public int maxVivres = 6;
    public int vivresValor = 1;
    public int vivresSpend = 0;

    public int material = 5;
    public int maxMaterial = 6;
    public int matValor = 1;
    public int matSpend = 0;

    public int population = 5;
    public int maxPopulation = 6;
    public int forpopValor = 1;
    public int forpopSpend = 0;

    public Text stalk;
    public Text totalStalk;
    public Text vivre;
    public Text maxVivre;
    public Text materio;
    public Text maxMaterio;
    public Text pop;
    public Text maxPop;

    private Liste_Stalkers _sl;

    private Mathieu_Choice _Mc;

    private Converters convert;

    // Start is called before the first frame update
    void Start()
    {
        convert = GameObject.Find("GameManager").GetComponent<Converters>();

        _Mc = GameObject.Find("GameManager").GetComponent<Mathieu_Choice>();

        _sl = GameObject.Find("GameManager").GetComponent<Liste_Stalkers>();
        totalStalk.text = "/" + maxStalker;
        stalk.text = " Stalkers : " + stalker;

        _c1.gameObject.SetActive(true);
        _c2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        StalkerUpdate();
        VivresUpdate();
        MatériauxUpdate();
        PopulationUpdate();

        if (stalker <= 1)
        {
            stalk.color = Color.red;
            totalStalk.color = Color.red;
        }

        if (stalker == 3)
        {
            stalk.color = Color.white;
            totalStalk.color = Color.white;
        }

        if (stalker == 2)
        {
            stalk.color = Color.white;
            totalStalk.color = Color.white;
        }

        if (stalker > 3)
        {
            stalk.color = Color.green;
            totalStalk.color = Color.green;
        }

        //  J_Choice.fillMat = ;

    }

    void StalkerUpdate()
    {
        if (convert.moreStalk == true && population >0 && material >0 && stalker < maxStalker && stalking != true)
        {
            for (int i = 0; i < _sl.stalkerlist.Length; i++)
            {
                if (_sl.stalkerlist[i].GetComponent<Stalker>().health == 0)
                {
                    _sl.stalkerlist[i].GetComponent<Stalker>().health = 3;
                }
            }

            material--;
            population--;
            stalker++;

            fillMat = 0.1f;
            FillMat.transform.localScale -= new Vector3(fillMat, 0f);
            fillPop = 0.1f;
            FillPop.transform.localScale -= new Vector3(fillPop, 0f);

            stalk.text = " Stalkers : " + stalker;
            Debug.Log("Material : " + material + "Population : " + population + "Stalker : " + stalker);

            convert.moreStalk = false;

        }

        if (stalker == maxStalker)
        {
            stalking = true;
        }
    }

    void VivresUpdate()
    {
        if (convert.moreGren == true && vivres > 0)
        {
            vivresSpend = (1 * vivresValor);
            Debug.Log("Vivres Spend = " + vivresSpend + "     " + "Vivres Valor = " + vivresValor);

            if (vivresSpend == 1)
            {
                vivres = vivres - vivresSpend;
                maxVivres++;
                fillRes = 0.1f;
                FillRes.transform.localScale -= new Vector3(fillRes, 0);
            }

            if (vivresSpend == 2)
            {
                vivres = vivres - vivresSpend;
                maxVivres++;
                fillRes = 0.2f;
                FillRes.transform.localScale -= new Vector3(fillRes, 0);
            }

            if (vivresSpend == 3)
            {
                vivres = vivres - vivresSpend;
                maxVivres++;
                fillRes = 0.3f;
                FillRes.transform.localScale -= new Vector3(fillRes, 0);
            }

            maxVivre.text = " / " + maxVivres;
            Debug.Log("Vivres : " + vivres + "Max Vivres : " + maxVivres);

            vivresValor++;
            Debug.Log("Dépense de vivres = " + vivresSpend);

            convert.moreGren = false;
        }

        if (vivres >= maxVivres)
        {
            vivres = maxVivres;
        }

        if (vivres <= 0)
        {
            vivres = 0;
            _c1.gameObject.SetActive(false);
            _c2.gameObject.SetActive(true);
            StartCoroutine("ReloadGame");
        }
    }

    void MatériauxUpdate()
    {
        if (convert.moreForge == true && material > 0)
        {
            matSpend = (1 * matValor);
            Debug.Log("Matériaux Spend = " + matSpend + "     " + "Matériaux Valor = " + matValor);

            if (matSpend == 1)
            {
                material = material - matSpend;
                maxMaterial++;
                fillMat = 0.1f;
                FillMat.transform.localScale -= new Vector3(fillMat, 0);
            }

            if (matSpend == 2)
            {
                material = material - matSpend;
                maxMaterial++;
                fillMat = 0.2f;
                FillMat.transform.localScale -= new Vector3(fillMat, 0);
            }

            if (matSpend == 3)
            {
                material = material - matSpend;
                maxMaterial++;
                fillMat = 0.3f;
                FillMat.transform.localScale -= new Vector3(fillMat, 0);
            }

            maxMaterio.text = " / " + maxMaterial;
            Debug.Log("Matériaux : " + material + "   " + "Max Matériaux : " + maxMaterial);

            matValor++;
            Debug.Log("Dépense de matériaux = " + matSpend);

            convert.moreForge = false;
        }

        if (material >= maxMaterial)
        {
            material = maxMaterial;
        }

        if (material <= 0)
        {
            material = 0;
            _c1.gameObject.SetActive(false);
            _c2.gameObject.SetActive(true);
            StartCoroutine("ReloadGame");
        }
    }

    void PopulationUpdate()
    {
        if (convert.moreConf == true && vivres > 0 && material > 0)
        {
            forpopSpend = (1 * forpopValor);
            Debug.Log("ForPop Spend = " + forpopSpend + "     " + "ForPopValor = " + forpopValor);


            if (forpopSpend == 1)
            {
                vivres = vivres - forpopSpend;
                material = material - forpopSpend;
                maxPopulation++;

                fillRes = 0.1f;
                FillRes.transform.localScale -= new Vector3(fillRes, 0);

                fillMat = 0.1f;
                FillMat.transform.localScale -= new Vector3(fillMat, 0);
            }

            if (forpopSpend == 2)
            {
                vivres = vivres - forpopSpend;
                material = material - forpopSpend;
                maxPopulation++;

                fillRes = 0.2f;
                FillRes.transform.localScale -= new Vector3(fillRes, 0);

                fillMat = 0.2f;
                FillMat.transform.localScale -= new Vector3(fillMat, 0);
            }

            if (forpopSpend == 3)
            {
                vivres = vivres - forpopSpend;
                material = material - forpopSpend;
                maxPopulation++;

                fillRes = 0.3f;
                FillRes.transform.localScale -= new Vector3(fillRes, 0);

                fillMat = 0.3f;
                FillMat.transform.localScale -= new Vector3(fillMat, 0);
            }

            maxPop.text = " / " + maxPopulation;
            Debug.Log("Matériaux : " + material + "    " + "Vivres : " + vivres + "    " + "Max Population : " + maxPopulation);

            forpopValor++;
            Debug.Log(" Dépense pour la population = " + forpopSpend);

            convert.moreConf = false;
        }

        if (population >= maxPopulation)
        {
            population = maxPopulation;
        }

        if (population <= 0)
        {
            population = 0;
            _c1.gameObject.SetActive(false);
            _c2.gameObject.SetActive(true);
            StartCoroutine("ReloadGame");

        }
    }

    IEnumerator ReloadGame()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Rechargement du level");
        SceneManager.LoadScene("Scene_Rendu");
    }
}
