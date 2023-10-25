using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToLevel : MonoBehaviour
{
    public string levelToLoad = "level 1"; 

    private void OnMouseDown() // start button function
    {
        
        SceneManager.LoadScene(levelToLoad);
    }
}
