using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heromovementtt : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector3 velocity;
    public float speed = 5f;
    public float jumpamount;
    public static bool saggidiyor, solgidiyor, zipliyor, ziplayabilir, ucabilir, diyalogg, diyalogg1;
    public Animator animator;
    public GameObject buton, konusmabuton, aliglama, bar, text, masktext, maskbutton, maskaliglama;




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
        StartCoroutine(bekleme());
        diyalogg = false;
        



    }

    void Update()
    {
      
        if (saggidiyor)
        {
            transform.position += velocity * 1 * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);

        }


        if (solgidiyor)
        {
            transform.position += velocity * -1 * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);

        }


        if (solgidiyor || saggidiyor)
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
                rb.velocity = new Vector2(0, 12 * jumpamount * Time.deltaTime);
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
    public void diyalog()
    {
        diyalogg = true;
    }
    public void diyalog1()
    {
        diyalogg1 = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "yer")
        {
            ziplayabilir = true;
        }
        if (collision.gameObject.name == "diyalogalgilama")
        {
            aliglama.SetActive(false);
            konusmabuton.SetActive(true);
            text.SetActive(true);
        }
        if (collision.gameObject.name == "algilamamaskman")
        {
            maskaliglama.SetActive(false);
            masktext.SetActive(true);
            maskbutton.SetActive(true);

        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "yer")
        {
            ziplayabilir = false;
        }
    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(0.3f);
        bar.SetActive(true);

    }



}
