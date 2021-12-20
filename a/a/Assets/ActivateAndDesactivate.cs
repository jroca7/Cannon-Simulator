using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateAndDesactivate : MonoBehaviour
{
    public string scene1;
    public string scene2;
    public string scene3;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene(scene1);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene(scene2);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene(scene3);
        }
    }
}
