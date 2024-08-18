using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class camerafolloww22 : MonoBehaviour
{
    public GameObject target, fade, image, haraketbutonlari, maskbuttonveyazi, hero1, diyalog2, siyah, ses;
    
   
   


    private void Start()
    {
        StartCoroutine(bekleme());
        StartCoroutine(bekleme1());
        

    }

    void Update()
    {
     
        


        transform.position = new Vector3(target.transform.position.x - 1, transform.position.y, -100);
        
        
        if (heromovementt.diyalog11)
        {
            target.transform.position = new Vector2(-55f,-2.04f);
            target.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
            maskbuttonveyazi.SetActive(false);
            haraketbutonlari.SetActive(false);
            hero1.SetActive(true);
            StartCoroutine(bekleme2());
            StartCoroutine(bekleme3());
            StartCoroutine(bekleme0());



        }
    }
    IEnumerator bekleme0()
    {
        yield return new WaitForSeconds(0.9f);
        ses.SetActive(true);
    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(1.5f);
        fade.SetActive(false);
    }
    IEnumerator bekleme1()
    {
        yield return new WaitForSeconds(1);
        image.SetActive(true);
    }
    IEnumerator bekleme2()
    {
        yield return new WaitForSeconds(1);
        diyalog2.SetActive(true);
    }
    IEnumerator bekleme3()
    {
        yield return new WaitForSeconds(35);
        siyah.SetActive(true);
        StartCoroutine(bekleme4());
    }
    IEnumerator bekleme4()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("heyelan");
    }


}
