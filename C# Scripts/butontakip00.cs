using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butontakip00 : MonoBehaviour
{
    public GameObject target;
    
    void Update()
    {
        
            transform.position = new Vector2(target.transform.position.x - 7.4f,transform.position.y);
        
        
    }
}
