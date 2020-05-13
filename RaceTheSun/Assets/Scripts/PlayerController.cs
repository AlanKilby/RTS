using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;

    public Rigidbody2D playerRB;

    public GameObject gameOverCanvas;
    public GameObject tutorialCanvas;
    // Start is called before the first frame update
    void Start()
    {
        playerRB.gravityScale = 0;
        Time.timeScale = 1;
        gameOverCanvas.SetActive(false);

        Invoke("TutorialDisappear", 5);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            playerRB.velocity = new Vector2(-movementSpeed, playerRB.velocity.y);
        }
        else if (Input.GetMouseButton(1))
        {
            playerRB.velocity = new Vector2(movementSpeed, playerRB.velocity.y);
        }
        else if(!Input.GetMouseButton(1) && !Input.GetMouseButton(0))
        {
            playerRB.velocity = new Vector2(0, playerRB.velocity.y);

        }


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacles")
        {
            gameOverCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }


    private void TutorialDisappear()
    {
        tutorialCanvas.SetActive(false);
    }
}
