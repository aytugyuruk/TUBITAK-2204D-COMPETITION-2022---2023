using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heromovementt : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector3 velocity;
    public float speed = 5f;
    public float jumpamount;
    public static bool saggidiyor1, solgidiyor1, zipliyor1, ziplayabilir1, ucabilir1, diyalog11;
    public Animator animator;
    public GameObject buton,  masktext, maskbutton, maskaliglama,nefes2,text1,algilama,alevses,susadimses,algilamatextsilme,nerdeysealevlerinicinde,algilamaotomatikyurume,sondiyalog,hero,sonalgilama,herokopya,sonses,nefes;
    



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
        
 

    }

    void Update()
    {
        
        if (saggidiyor1)
            {
                transform.position += velocity * 1 * speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
           
            }
       

        if (solgidiyor1)
        {
            transform.position += velocity * -1 * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
          
            
        }
                

            if (solgidiyor1 || saggidiyor1)
            {
                animator.SetBool("kosuyor", true);
            }
            else
            {
                animator.SetBool("kosuyor", false);
            }
            if (zipliyor1)
            {
                if (ziplayabilir1)
                {
                    rb.velocity = new Vector2(0, 12 * jumpamount*Time.deltaTime);
                }
            }

        


    }
    public void soll()
    {
        solgidiyor1 = true;
        
    }
    public void solbirakk()
    {
        solgidiyor1 = false;
      

    }
    public void sagg()
    {
        saggidiyor1 = true;
        
    }
    public void sagbirakk()
    {
        saggidiyor1 = false;
        

    }
    public void ziplaa()
    {
        zipliyor1 = true;
    }
    public void ziplabirakk()
    {
        zipliyor1 = false;

    }
    
    public void diyalog111()
    {
        diyalog11 = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "yer")
        {
            ziplayabilir1 = true;
        }
        
        if (collision.gameObject.name == "algilamamaskman")
        {
            maskaliglama.SetActive(false);
            masktext.SetActive(true);
            maskbutton.SetActive(true);

        }
        if (collision.gameObject.name == "algilamafire")
        {
            text1.SetActive(true);
            alevses.SetActive(true);
            Destroy(algilama);
        }
        
        if (collision.gameObject.name == "algilamatextsilme")
        {
            Destroy(text1);
            Destroy(algilamatextsilme);
            nerdeysealevlerinicinde.SetActive(true);
            velocity = new Vector3(28, 0, 0);
            StartCoroutine(bekleme11111());

        }
        if (collision.gameObject.tag == "ates")
        {
            transform.position = new Vector3(-94, -2.032f, 64.2f);
        }
        if (collision.gameObject.name == "algilamaotomatikyurume")
        {
            buton.SetActive(false);
            nefes.SetActive(true);
            zipliyor1 = false;
            saggidiyor1 = false;
            StartCoroutine(bekleme012());
            Destroy(algilamaotomatikyurume);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            
            StartCoroutine(bekleme01());
            
        }
        if (collision.gameObject.name == "sonalgilama")
        {
            sondiyalog.SetActive(true);
            Destroy(sonalgilama);
            speed = 0f;
            herokopya.SetActive(true);
            sonses.SetActive(true);
            Destroy(hero);
            
        }


    }
    IEnumerator bekleme012()
    {
        yield return new WaitForSeconds(16f);
        nefes2.SetActive(true);


    }
    IEnumerator bekleme01()
    {
        yield return new WaitForSeconds(0f);
        rb.velocity = new Vector2(-0.6f*speed, 0);


    }
    IEnumerator bekleme11111()
    {
        yield return new WaitForSeconds(10f);
        susadimses.SetActive(true);
        velocity = new Vector3(13, 0, 0);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "yer")
        {
            ziplayabilir1 = false;
        }
       
    }
   



}
