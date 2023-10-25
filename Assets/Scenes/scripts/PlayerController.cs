using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour

{
    private void Start()
    {
        Cursor.visible = false; // disables mouse cursor
    }
    public string StartingScene = "StartingScene"; // enters next scene
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //moevement
        mousePos.z = 0;

        transform.position = mousePos; //chnages the position

    }
}