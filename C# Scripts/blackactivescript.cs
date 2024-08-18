using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class siyahakitfscript : MonoBehaviour
{
    public GameObject siyah;
    void Start()
    {
        StartCoroutine(bekleme());
        StartCoroutine(bekleme1());
    }

    
    
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(10f);
        siyah.SetActive(true);
        
    }
    IEnumerator bekleme1()
    {
        yield return new WaitForSeconds(12.5f);
        SceneManager.LoadScene("emegigecenler");

    }
}
