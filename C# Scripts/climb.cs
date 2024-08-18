using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tirmanma : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    bool tirmanabilir;
    int tirmanmahizi = 9;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tirmanabilir)
        {
            transform.Translate(0, tirmanmahizi * Time.deltaTime, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "merdiven")
        {
            rb.gravityScale = 0;

            tirmanabilir = true;
           
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "merdiven")
        {

            tirmanabilir = false;
            rb.gravityScale = 3;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "merdiven")
        {

            tirmanabilir = true;
        }
    }
}
