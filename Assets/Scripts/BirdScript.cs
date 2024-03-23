using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    public GameObject gameOverScreen;

     public AudioClip backgroundClip; // The audio clip to be played in the background
     private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        rb = GetComponent<Rigidbody2D>();
        
    }

    

    // Update is called once per frame
   void Update()
{
    if (transform.position.y >= 25.5f || transform.position.y <= -25.5f)
    {
        // Game over logic here
        gameOver();
    }
    
    if (Input.GetMouseButtonDown(0) && birdIsAlive)
    {
        myRigidbody.velocity = Vector2.up * flapStrength;
    }
}

    void restartGame()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
