using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camerafollowww2 : MonoBehaviour
{
    public GameObject target, fadebas,  hero,   butonveyazi, haraketbutonlari, diyalog, siyah, bar, audioobject, atlamabutton,baslangicses,square,bar1;
    public static bool atla, sahnegecti;

    void Start()
    {
        StartCoroutine(bekleme());
        atla = false;
        sahnegecti = false;
        StartCoroutine(bekleme2222());
        StartCoroutine(beklemeses());
        bar1 = GameObject.FindWithTag("bar");

    }


    void Update()
    {
        transform.position = new Vector3(target.transform.position.x-1, transform.position.y, -480);
        if (heromovementt.diyalog11)
        {

            audioobject.SetActive(true);
            haraketbutonlari.SetActive(false);
            butonveyazi.SetActive(false);
            bar1.transform.position = new Vector2(-48.6f, 4.8f);
            square.transform.position = new Vector2(-55.3f, -2f);
            hero.transform.position = new Vector2(-55.3f, -2.03f);
            diyalog.SetActive(true);
            StartCoroutine(bekleme2());
            StartCoroutine(bekleme3());

        }
        if (atla)
        {
            siyah.SetActive(true);
            StartCoroutine(bekleme4());
        }
    }

    IEnumerator beklemeses()
    {
        yield return new WaitForSeconds(0.4f);
        baslangicses.SetActive(true);
    }
    IEnumerator bekleme2222()
    {
        yield return new WaitForSeconds(0.1f);
        sahnegecti = true;
    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(1.5f);
        fadebas.SetActive(false);
    }
    
    IEnumerator bekleme2()
    {
        yield return new WaitForSeconds(34f);
        siyah.SetActive(true);
       

    }
    IEnumerator bekleme3()
    {
        yield return new WaitForSeconds(37.2f);
        SceneManager.LoadScene("heyelan");

    }
    IEnumerator bekleme4()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Dialog1devam");
        

    }
    public void atlama()
    {

        atla = true;
    }

}
