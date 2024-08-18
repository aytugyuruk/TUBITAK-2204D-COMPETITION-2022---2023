using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tüpscript : MonoBehaviour
{
    public GameObject tüp;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "hero")
        {
            Destroy(tüp);
        }
    }
}
