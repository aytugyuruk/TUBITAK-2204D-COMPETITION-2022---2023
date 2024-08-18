using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class herominigamescript : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector3 velocity;
    public float speed,jump;
    public bool sag, sol,bitti;
    public GameObject butonlar, siyahkapanis;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (sag)
        {
            transform.position += velocity * 1 * speed * Time.deltaTime;

        }

        
        if (sol)
        {
            transform.position += velocity * -1 * speed * Time.deltaTime;

        }
        if (maincamerascript.bitti)
        {
            Destroy(butonlar);
            sag = false;
            sol = false;
            StartCoroutine(bekleme0());
        }
        
    }
    IEnumerator bekleme0()
    {
        yield return new WaitForSeconds(0.5f);
        rb.AddForce(Vector2.up * jump);
        StartCoroutine(bekleme());

    }
    IEnumerator bekleme()
        {
            yield return new WaitForSeconds(3f);
            siyahkapanis.SetActive(true);
            StartCoroutine(bekleme1());

        }
        IEnumerator bekleme1()
        {
            yield return new WaitForSeconds(2.1f);
            SceneManager.LoadScene("SampleScene1");

        }
        public void sag1()
        {
            sag = true;
        }
        public void sag1cek()
        {
            sag = false;
        }
        public void sol1()
        {
            sol = true;
        }
        public void sol1cek()
        {
            sol = false;
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "sýnýr")
            {
                SceneManager.LoadScene("minigame");
            }
        }
    } 
