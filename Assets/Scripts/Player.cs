using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Score scoreScript;

    public bool dead;

    public AudioSource audioSource;
    public AudioClip soundA;
    public AudioClip soundB;

    void Awake()
    {
        dead = false;

        scoreScript.TotalScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = new Vector3(mousePos.x, mousePos.y, 0f);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            dead = true;
            audioSource.PlayOneShot(soundB);
            OnDeath();
        }

        if (collision.gameObject.tag == "Score Plus")
        {
            ScorePlus scoreplus = collision.GetComponent<ScorePlus>();
            scoreScript.ScorePlus(scoreplus.plusPower);
            audioSource.PlayOneShot(soundA);
        }
    }

    void OnDeath()
    {
        GameManager.Instance.UpdateScore();
        SceneManager.LoadScene(2);
    }
}
