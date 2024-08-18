using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahnegecisss : MonoBehaviour
{
  
    void Start()
    {
        StartCoroutine(bekleme());
    }

   
    void Update()
    {
        
    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(41);
        SceneManager.LoadScene("animation");

    }
}
