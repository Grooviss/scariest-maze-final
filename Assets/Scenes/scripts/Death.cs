using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Walls : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) //when you touch a black "wall" you get teleported to the start
    {
        if (collision.gameObject.CompareTag("Circle"))
        {
            SceneManager.LoadScene("StartingScene");
        }
    }
}