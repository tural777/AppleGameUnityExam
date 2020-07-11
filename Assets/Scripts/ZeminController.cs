using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZeminController : MonoBehaviour
{

    float live = 100.0f;
    float currentLive = 100.0f;

    public Image imageLive;
    public GameObject panel;
    public AudioSource audioZ;


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "apple")
        {
            Destroy(collision.gameObject);
            audioZ.Play();

            currentLive -= 10.0f;
            imageLive.fillAmount = currentLive / live;


            if (currentLive <= 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0.0f;
            }
        }
    }
    
}
