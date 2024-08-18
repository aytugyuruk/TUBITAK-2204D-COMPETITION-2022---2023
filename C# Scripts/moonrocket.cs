using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moonroket : MonoBehaviour
{
    public GameObject baloncuk, hero,fade;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
        StartCoroutine(bekleme());
    }

    
    void Update()
    {
        
    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(1.5f);
        baloncuk.SetActive(true);
    }
    IEnumerator bekleme1()
    {
        yield return new WaitForSeconds(2.5f);
        rb.velocity = new Vector2(0, 0.5f);
        StartCoroutine(bekleme2());
    }
    IEnumerator bekleme2()
    {
        yield return new WaitForSeconds(4f);
        fade.SetActive(true);
        StartCoroutine(bekleme3());
    }
    IEnumerator bekleme3()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("donus");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "hero")
        {
            hero.SetActive(false);
            StartCoroutine(bekleme1());
        }
    }
}
