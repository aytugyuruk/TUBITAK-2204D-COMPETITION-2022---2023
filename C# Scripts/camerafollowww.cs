using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class camerafollowww : MonoBehaviour
{
    public GameObject target, buton1,buton2,buton3,diyalog,ses,square;
    public static bool aktif;



    private void Start()
    {
        Application.targetFrameRate = 60;
        StartCoroutine(bekleme());
        StartCoroutine(bekleme1());
        aktif = false;
       
        
    }

    void Update()
    {
        
        transform.position = new Vector3(target.transform.position.x-0.5f, transform.position.y, -100);


    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(1.2f);
        diyalog.SetActive(true);
        ses.SetActive(true);
    }
    IEnumerator bekleme1()
    {
        yield return new WaitForSeconds(24.5f);
        aktif = true;
       


    }



}
