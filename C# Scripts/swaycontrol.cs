using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
using UnityEngine.SceneManagement;

public class sallanmakontrol : MonoBehaviour
{
    public bool ok;
    public GameObject heyelan,heyelan1,kapanis,ses;
    void Start()
    {

        ok = false;
        StartCoroutine(bekleme());
        transform.position = new Vector3(-6464.7f, 0, -3000);
        Application.targetFrameRate = 60;
        StartCoroutine(bekleme1());
        StartCoroutine(bekleme0());
        StartCoroutine(bekleme2());
        StartCoroutine(bekleme3());
        StartCoroutine(bekleme4());
    }


    void Update()
    {

        if (ok)
        {
            gameObject.GetComponent<CameraShaker>().ShakeOnce(0.3f, 2f, 3f, 1f);
        }
        


    }
    IEnumerator bekleme0()
    {
        yield return new WaitForSeconds(0.9f);
        ses.SetActive(true);
    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(1.5f);
        ok = true;
    }
    IEnumerator bekleme1()
    {
        yield return new WaitForSeconds(10.2f);
        heyelan.SetActive(true);
    }
    IEnumerator bekleme2()
    {
        yield return new WaitForSeconds(12f);
        heyelan1.SetActive(true);
    }
    IEnumerator bekleme3()
    {
        yield return new WaitForSeconds(12.5f);
        kapanis.SetActive(true);
    }
    IEnumerator bekleme4()
    {
        yield return new WaitForSeconds(18f);
        SceneManager.LoadScene("Dialog2devam");
    }
}

