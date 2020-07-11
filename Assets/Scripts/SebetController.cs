using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SebetController : MonoBehaviour
{
    public float speed;
    public TextMeshProUGUI scoreText;
    public ParticleSystem effect;
    public AudioSource audio;

    int Score = 0;


    void Start()
    {
        effect.Stop();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "apple")
        {
            audio.Play();
            effect.Play();
            Score += 1;
            scoreText.text = "Score: " + Score.ToString();

            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
}
