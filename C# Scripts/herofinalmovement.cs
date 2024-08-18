using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class herosonmovement : MonoBehaviour
{
    public GameObject siyah,arkaplanses;
    
    void Start()
    {
        StartCoroutine(bekleme());
        StartCoroutine(bekleme1());
        arkaplanses = GameObject.FindWithTag("arkaplanses");
    }

    
    void Update()
    {
        
    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(6f);
        siyah.SetActive(true);
    }
    IEnumerator bekleme1()
    {
        yield return new WaitForSeconds(11.5f);
        Destroy(arkaplanses);
        SceneManager.LoadScene("video");

        
    }
}
