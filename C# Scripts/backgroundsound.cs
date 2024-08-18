using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arkaplanses : MonoBehaviour
{
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.loop = true;
    }
    private static arkaplanses instance = null;
    private static arkaplanses Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        
    }



}
