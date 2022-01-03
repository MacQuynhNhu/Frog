using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ech : MonoBehaviour
{

    GameController gco;
    public void Start()
    {
        gco = FindObjectOfType<GameController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            gco.IncreaseScore();
            Debug.Log(gco.Score);
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("DeathZone"))
        {
            gco.IsGameover = true;
            Debug.Log("Gameover");
        }
    }
}
