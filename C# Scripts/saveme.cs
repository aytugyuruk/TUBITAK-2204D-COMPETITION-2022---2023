using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveme : MonoBehaviour
{
    
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    
}
