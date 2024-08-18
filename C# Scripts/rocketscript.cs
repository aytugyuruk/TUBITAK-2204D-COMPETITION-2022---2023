using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class roketscript : MonoBehaviour
{
    public static bool ucabilir, cameraucma;
    public GameObject hero, yazilar, fade,fade2, butonlar, smoke,roketses;
    public Transform hero1;
    public Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cameraucma = false;
      
    }
    void Update()
    {
        if (ucabilir)
        {
            hero1.transform.position = new Vector2(65.91f, -2.845f);
            hero1.parent = transform;
            yazilar.SetActive(false);
            hero.SetActive(false);
            fade.SetActive(true);
            butonlar.SetActive(false);
            StartCoroutine(bekleme());
            StartCoroutine(bekleme1());
            StartCoroutine(bekleme0());
            


        }
    }
    public void ucus()
    {
        ucabilir = true;
    }
    IEnumerator bekleme0()
    {
        yield return new WaitForSeconds(3);
        roketses.SetActive(true);
    }
    IEnumerator bekleme(){
        yield return new WaitForSeconds(3);
        smoke.SetActive(true);
    }
    IEnumerator bekleme1()
    {
        yield return new WaitForSeconds(7);
        rb.gravityScale = 1;
        rb.velocity = new Vector2(0, 4);
        cameraucma = true;
        StartCoroutine(bekleme2());
        StartCoroutine(bekleme3());


    }
    IEnumerator bekleme2()
    {
        yield return new WaitForSeconds(9);
        fade2.SetActive(true);

        
    }
    IEnumerator bekleme3()
    {
        yield return new WaitForSeconds(12);
        SceneManager.LoadScene("bolum1yazisi");


    }

}
