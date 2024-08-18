using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector3 velocity;
    public float speed = 5f;
    public float jumpamount;
    public bool saggidiyor, solgidiyor, zipliyor,ziplayabilir,ucabilir;
    public Animator animator;
    bool basladi;
    bool basladi1;
    public GameObject text, roketbuton, text1, butonlar;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(bekleme());
        basladi = false;
        basladi1 = true;
        Application.targetFrameRate = 60;
        roketbuton.SetActive(false);
        butonlar.SetActive(false);
        
        
    }

    void Update()
    {
        if (basladi)
        {
            velocity = new Vector3(1, 0, 0);

            if (saggidiyor)
            {
                
                transform.position += velocity * 1 * speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
          

            if (solgidiyor)
            {
                animator.SetBool("kosuyor", true);
                transform.position += velocity * -1 * speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
            if(solgidiyor || saggidiyor)
            {
                animator.SetBool("kosuyor", true);
            }
            else
            {
                animator.SetBool("kosuyor", false);
            }
            if (zipliyor)
            {
                if (ziplayabilir)
                {
                    rb.velocity = new Vector2(0, 12*jumpamount);
                }
            }    
           
        }
       
       
    }
    public void sol()
    {
        solgidiyor = true;
    }
    public void solbirak()
    {
        solgidiyor = false;

    }
    public void sag()
    {
        saggidiyor = true;
    }
    public void sagbirak()
    {
        saggidiyor = false;

    }
    public void zipla()
    {
        zipliyor = true;
    }
    public void ziplabirak()
    {
        zipliyor = false;

    }
  


    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(2.4f);
        if (basladi1)
        {
            animator.SetBool("kosuyor", true);
            rb.velocity = new Vector3(8f, 0f);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {  
        if (collision.gameObject.name == "baslama")
        {
            rb.drag = 5f;
            rb.gravityScale = 3f;
            basladi1 = false;
            basladi = true;
            text.SetActive(true);
            butonlar.SetActive(true);
        }
        if (collision.gameObject.name == "roket")
        {
            roketbuton.SetActive(true);
            text1.SetActive(true);
        }
       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "yer")
        {
            ziplayabilir = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "yer")
        {
            ziplayabilir = false;
        }
    }



}
