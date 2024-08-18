using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rubbishspawn : MonoBehaviour
{
    public GameObject rubbish;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        float xpos = Random.Range(-8.5f, 8.5f);
        float ypos = Random.Range(6.37f, 8.5f);
        if (collision.gameObject.name == "algilama")
        {
            transform.position = new Vector2(xpos, ypos);
        }
        if (collision.gameObject.name == "algilama2")
        {
            Destroy(rubbish);
        }
        if (collision.gameObject.name == "hero")
        {
            SceneManager.LoadScene("minigame");
        }

    }
}

