using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class roketharaketuzayda : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject siyah;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        rb.velocity = new Vector2(0.8f, 0.2f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "algilayici")
        {
            siyah.SetActive(true);
            StartCoroutine(bekleme());
        }
    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("10yearslater");
    }
}
