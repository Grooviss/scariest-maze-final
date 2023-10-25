using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public string NextScene = "Level 2";
    private void OnTriggerEnter2D(Collider2D collision) //switches the level one by one
    {
        if (collision.gameObject.tag.Contains("Circle"))
        {
            SceneManager.LoadScene(NextScene);
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(NextScene);
    }
}