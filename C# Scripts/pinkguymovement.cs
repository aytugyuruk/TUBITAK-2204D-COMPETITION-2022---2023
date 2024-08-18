using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinkguymovement : MonoBehaviour
{
    public float hiz, deger;
    public Animator anim;
    public bool normal;
    

    private void Start()
    {
        normal = true;
    }


    void Update()
    {
        if (normal)
        {
            gameObject.transform.Translate(new Vector3(deger * hiz * Time.deltaTime, 0, 0));
            anim.SetBool("kosuyor", true);
        }
       
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "varilacak")
        {
            deger *= 1;
            transform.Rotate(0, -180, 0);
        }
        
    }
}
