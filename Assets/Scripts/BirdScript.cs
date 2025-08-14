using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public GameManager gameManager;
    // public bool isGameActive = true;
    private float flapStrength = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameActive == true)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver(); 
    }
}
