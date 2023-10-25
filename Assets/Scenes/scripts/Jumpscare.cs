using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Jumpscare : MonoBehaviour
{
    public GameObject jumpscare;
    public AudioSource jsound;
    public string StartingScene = "StartingScene";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Contains("Circle")) // when you touch the "teleporter" you get a jump screen and a very loud sound :D
        {
            jumpscare.SetActive(true);
            jsound.Play();
            Invoke("Restart", 3f); // after 3 seconds restarts the game
        }
    }

   void Restart() // restart
        {
            SceneManager.LoadScene(StartingScene);
        }
    }
 

