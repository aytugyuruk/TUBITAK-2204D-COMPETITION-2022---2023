using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butontakip11 : MonoBehaviour
{
    public GameObject target;
   
    void Update()
    {
        
            transform.position = new Vector2(target.transform.position.x - 4.3f, transform.position.y);
        

    }
}
