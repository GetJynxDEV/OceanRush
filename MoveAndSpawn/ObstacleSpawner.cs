using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 1;
    //[SerializeField] private float _heightRange = 0.45f;

    [SerializeField] private GameObject purpCoral;
    [SerializeField] private GameObject greenCoral;
    [SerializeField] private GameObject jellyFish;

    int randomVal = 0;

    private float timer;

    private void Start()
    {
        randomSpawner();
    }

    private void Update()
    {
        if (timer > maxTime)
        {

            randomSpawner();

            timer = 0;
            randomVal = 0;
        }

        timer += Time.deltaTime;
    }

    void randomSpawner()
    {
        purpleCoralSpawner();

        randomVal = Random.Range(1, 4);

        if (randomVal == 1)
        {
            Invoke("purpleCoralSpawner", 3f);
            Invoke("jellyFishSpawner", 7f);
        }

        else if (randomVal == 2)
        {
            Invoke("purpleCoralSpawner", 3f);
            Invoke("greenCoralSpawner", 5f);
            Invoke("jellyFishSpawner", 9f);
        }

        else if (randomVal == 3)
        {
            Invoke("jellyFishSpawner", 4f);
            Invoke("greenCoralSpawner", 7f);
            Invoke("jellyFishSpawner", 12f);
        }

        else if (randomVal == 4)
        {
            Invoke("purpleCoralSpawner", 1f);
            Invoke("greenCoralSpawner", 3f);
            Invoke("purpleCoralSpawner", 6f);
        }

    }






    void purpleCoralSpawner()
    {
        Vector3 spawnPosP = transform.position = new Vector3(1, -3.87f, 1);

        GameObject barnecleP = Instantiate(purpCoral, spawnPosP, Quaternion.identity);

        Destroy(barnecleP, 25f);
    }

    void greenCoralSpawner()
    {
        Vector3 spawnPosG = transform.position = new Vector3(1, -3.87f, 1);

        GameObject barnecleG = Instantiate(greenCoral, spawnPosG, Quaternion.identity);

        Destroy(barnecleG, 25f);
    }

    void jellyFishSpawner()
    {
        Vector3 spawnPosJ = transform.position = new Vector3(0, Random.Range(1, -6), 0);

        GameObject barnecleJ = Instantiate(jellyFish, spawnPosJ, Quaternion.identity);

        Destroy(barnecleJ, 25f);
    }
}
