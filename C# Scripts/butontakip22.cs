using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butontakip22 : MonoBehaviour
{
    public GameObject target;
   
    void Update()
    {
        
            transform.position = new Vector2(target.transform.position.x + 6.5f,transform.position.y);
        

    }
}
