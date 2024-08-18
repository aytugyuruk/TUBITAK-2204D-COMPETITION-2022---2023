using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class okanim : MonoBehaviour
{
   
    void Start()
    {
        StartCoroutine(bekleme());
    }


   
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(3.4f);
        Destroy(this.gameObject);
    }
}
