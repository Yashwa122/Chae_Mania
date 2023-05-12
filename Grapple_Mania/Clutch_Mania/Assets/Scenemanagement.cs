using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanagement : MonoBehaviour
{
    public void Multiplayer()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Tutorial()
    {
        //I'm gonna add a tutorial scene
        Debug.Log("Tutorial level coming later");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
