using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincamerascript : MonoBehaviour
{
    public GameObject siyah,algilama2;
    public static bool bitti;
    void Start()
    {
        StartCoroutine(bekleme());
        StartCoroutine(bekleme1());

    }  
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(1.7f);
        siyah.SetActive(false);
    }
    IEnumerator bekleme1()
    {
        yield return new WaitForSeconds(22f);
        algilama2.SetActive(true);
        StartCoroutine(bekleme2());
    }
    IEnumerator bekleme2()
    {
        yield return new WaitForSeconds(3f);
        bitti = true;
        
    }
}
