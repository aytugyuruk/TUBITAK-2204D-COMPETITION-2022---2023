using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahnegecis10yılsonra : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(bekleme());
    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(3.7f);
        SceneManager.LoadScene("moon");
    }
}
