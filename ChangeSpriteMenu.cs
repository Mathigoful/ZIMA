using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteMenu : MonoBehaviour


{
    public Sprite _Ville;
    public Sprite _VilleCasser;



    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = _Ville;
    }

    private void OnCollision(Collision2D other)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = _VilleCasser;
    }
}