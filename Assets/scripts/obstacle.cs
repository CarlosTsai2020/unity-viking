using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class obstacle : MonoBehaviour
{

    PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Viking")
        {
            if (transform.gameObject.name == "DragonSoulEaterPurplePBR")
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                playerMovement.speed = 3f;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Viking")
        {
            playerMovement.speed = 10f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
