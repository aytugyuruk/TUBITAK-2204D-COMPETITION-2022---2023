using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class roketscriptklim : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject fade;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
    }

    
    void Update()
    {
        rb.velocity = new Vector2(0, -3.5f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "algilama")
        {
            fade.SetActive(true);
            StartCoroutine(bekleme());
        }

    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("minigame");

    }
}
