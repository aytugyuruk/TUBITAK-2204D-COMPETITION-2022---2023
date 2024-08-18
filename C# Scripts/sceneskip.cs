using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahnegecisbolum1 : MonoBehaviour
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
        yield return new WaitForSeconds(7.7f);
        SceneManager.LoadScene("SpaceMoon");
    }
}
