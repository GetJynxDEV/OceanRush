using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public GameObject transtiion;

    public void playGame() //Fade in and switch scene to startGame
    {
        Debug.Log("Play Button Clicked");

        transtiion.SetActive(true);

        Invoke("startGame", 3);
    }

    public void startGame()
    {
        SceneManager.LoadSceneAsync("Game");
    }

    public void mainMenu()
    {
        Debug.Log("Main Menu Button Clicked");

        SceneManager.LoadSceneAsync("Main Menu");
    }

    public void quitGame()
    {
        Debug.Log("Quit Button Clicked");

        Application.Quit();
    }

 
}
