using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class gameOverScript : MonoBehaviour
{
    [Header("Player Object")]
    [SerializeField] GameObject playerOneObject;
    [SerializeField] GameObject playerTwoObject;

    [SerializeField] GameObject GameOverPanel;

    [SerializeField] GameObject objectSpawner;

    [SerializeField] GameObject GameOverSC;

    private void Update()
    {
        if (playerOneObject.activeInHierarchy == true && playerTwoObject.activeInHierarchy == true)
        {

        }

        else if(playerOneObject.activeInHierarchy == false && playerTwoObject.activeInHierarchy == false)
        {
            GameOverPanel.SetActive(true);
            GameEnd();
            GameOverSC.GetComponent<gameOverScript>().enabled = false;
        }
    }

    private void GameEnd()
    {
        objectSpawner = GameObject.Find("ObjectSpawner");

        objectSpawner.GetComponent<ObstacleSpawner>().enabled = false;

    }
}
