using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bartakip : MonoBehaviour
{
    public GameObject target1;



    void Update()
    {

        transform.position = new Vector3(target1.transform.position.x + 7.5f, transform.position.y, 109);
    }
}
