using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerayitakip1 : MonoBehaviour
{
    public GameObject target, bar;
    void Start()
    {
        bar = GameObject.FindWithTag("bar");

    }


    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);


        bar.transform.parent = this.gameObject.transform;
       
    }
}
