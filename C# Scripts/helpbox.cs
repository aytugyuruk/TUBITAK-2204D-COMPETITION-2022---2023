using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canBari : MonoBehaviour
{

    public float can, animasyonyavasligi;
    private float maxcan, gercekscale;

    void Start()
    {
        maxcan = can;
        StartCoroutine(saniyedebir());
    }


    void Update()
    {
        gercekscale = can / maxcan;
        if (transform.localScale.x > gercekscale)
        {
            transform.localScale = new Vector3(transform.localScale.x - (transform.localScale.x - gercekscale) / animasyonyavasligi, transform.localScale.y, transform.localScale.z);
        }

    }
    IEnumerator saniyedebir()
    {
        yield return new WaitForSeconds(1f);
        if (can > 0)
        {
            can -= 0.35f;
        }
        StartCoroutine(saniyedebir());
    }
}
