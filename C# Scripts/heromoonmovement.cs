using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heromoonmovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    public bool kosma1, kosma2, kosma3;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(bekleme());
        kosma1 = false;
        kosma2 = false;
        kosma3 = false;
    }

   
    void Update()
    {
        if (kosma1)
        {
            rb.velocity = new Vector2(-0.70f, 0.3f);
            animator.SetBool("kosuyor", true);
        }
        else if (kosma2)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            rb.velocity = new Vector2(0.65f, 0f);
            animator.SetBool("kosuyor", true);
            
        }
        else if (kosma3)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            rb.velocity = new Vector2(-0.65f, 0.1f);
            animator.SetBool("kosuyor", true);

        }
    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(6f);
        kosma1 = true;
       

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "algilama")
        {
            kosma1 = false;
            kosma2 = true;
          
        }
        if (collision.gameObject.name == "algilama1")
        {
            kosma2 = false;
            kosma3 = true;

        }
    }
}
