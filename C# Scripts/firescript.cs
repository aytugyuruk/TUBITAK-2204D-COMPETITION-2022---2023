using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atesscript : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        StartCoroutine(bekleme());
    }

   
    void Update()
    {
        
    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(1f);
        anim.SetBool("gecebilir",true);
    }
}
