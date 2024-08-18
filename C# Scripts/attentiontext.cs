using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uyarıyazı : MonoBehaviour
{
   
    void Start()
    {
        StartCoroutine(bekleme());
    }

    
    
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(4.5f);
        Destroy(this.gameObject);
    }
}
