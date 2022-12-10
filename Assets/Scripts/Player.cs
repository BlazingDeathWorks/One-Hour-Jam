using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Score scoreScript;

    public bool dead;

    void Start()
    {
        dead = false;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
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
        }

        if (collision.gameObject.tag == "Score Plus")
        {
            ScorePlus scoreplus = collision.GetComponent<ScorePlus>();
            scoreScript.ScorePlus(scoreplus.plusPower);
        }
    }
}
