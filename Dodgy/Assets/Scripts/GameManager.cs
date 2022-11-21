using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    [Header("Spawner")]
    [SerializeField] GameObject fireballPrefabUP;
    [SerializeField] GameObject fireballPrefabDown;
    [SerializeField] GameObject fireballPrefabLeft;
    [SerializeField] GameObject fireballPrefabRight;

    [SerializeField] Transform spawnPosTopLeft;
    [SerializeField] Transform spawnPosTopMid;
    [SerializeField] Transform spawnPosTopRight;

    [SerializeField] Transform spawnPosDownLeft;
    [SerializeField] Transform spawnPosDownMid;
    [SerializeField] Transform spawnPosDownRight;

    [SerializeField] Transform spawnPosLeftTop;
    [SerializeField] Transform spawnPosLeftMid;
    [SerializeField] Transform spawnPosLeftDown;


    [SerializeField] Transform spawnPosRightTop;
    [SerializeField] Transform spawnPosRightMid;
    [SerializeField] Transform spawnPosRightDown;



    [SerializeField] Transform[] collectableSpawnPoints;

    [SerializeField] int maxPos;
    [SerializeField] float startDelay, RepeatDelay, minRepeatDelay, difficultyIncrementDelay;

    [SerializeField] GameObject gemCollectable;

    [SerializeField] GameObject gameOverObject;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        InvokeRepeating("Spawn", startDelay, RepeatDelay);
        InvokeRepeating("SpawnFromEitherLeftOrRight", 10f, RepeatDelay);
        InvokeRepeating("SpawnCollectable", 2, 5);
        InvokeRepeating("DifficultyManage", 2, difficultyIncrementDelay);

    }

    void Spawn()
    {
        int random = Random.Range(1, maxPos);
        if(random == 1)
        {
            Spawn_FromTopLeft();
        }

        if(random == 2)
        {
            Spawn_FromTopMid();
        }

        if(random == 3)
        {
            Spawn_FromTopRight();
        }

        if (random == 4)
        {
            Spawn_FromDownLeft();
        }

        if (random == 5)
        {
            Spawn_FromDownMid();
        }

        if (random == 6)
        {
            Spawn_FromDownRight();
        }
    }

    void Spawn_FromTopLeft()
    {
        Instantiate(fireballPrefabUP, spawnPosTopLeft.position, Quaternion.identity);
    }

    void Spawn_FromTopMid()
    {
        Instantiate(fireballPrefabUP, spawnPosTopMid.position, Quaternion.identity);
    }

    void Spawn_FromTopRight()
    {
        Instantiate(fireballPrefabUP, spawnPosTopRight.position, Quaternion.identity);
    }

    void Spawn_FromDownLeft()
    {
        Instantiate(fireballPrefabDown, spawnPosDownLeft.position, Quaternion.identity);
    }

    void Spawn_FromDownMid()
    {
        Instantiate(fireballPrefabDown, spawnPosDownMid.position, Quaternion.identity);
    }

    void Spawn_FromDownRight()
    {
        Instantiate(fireballPrefabDown, spawnPosDownRight.position, Quaternion.identity);
    }

    

    void SpawnFromLeft()
    {
        int index = Random.Range(1, 4);

        switch (index)
        {
            case 1:
            {
                    Spawn_FromleftTop();
               break;
            }

            case 2:
            {
                    Spawn_FromleftMid();
               break;
            }

            case 3:
            {
                    Spawn_FromleftDown();
               break;
            }
        }
    }

    void Spawn_FromleftTop()
    {
        Instantiate(fireballPrefabLeft, spawnPosLeftTop.position, Quaternion.identity);
    }

    void Spawn_FromleftMid()
    {
        Instantiate(fireballPrefabLeft, spawnPosLeftMid.position, Quaternion.identity);
    }

    void Spawn_FromleftDown()
    {
        Instantiate(fireballPrefabLeft, spawnPosLeftDown.position, Quaternion.identity);
    }


    void Spawn_FromRight()
    {
        int index = Random.Range(1, 4);

        switch (index) 
        {
            case 1:
                {
                    Spawn_FromRightTop();
                    break;
                }

            case 2:
                {
                    Spawn_FromRightMid();
                    break;
                }

            case 3:
                {
                    Spawn_FromRightDown();
                    break;
                }

        }

    }
    void Spawn_FromRightTop()
    {
        Instantiate(fireballPrefabRight, spawnPosRightTop.position, Quaternion.identity);
    }

    void Spawn_FromRightMid()
    {
        Instantiate(fireballPrefabRight, spawnPosRightMid.position, Quaternion.identity);
    }

    void Spawn_FromRightDown()
    {
        Instantiate(fireballPrefabRight, spawnPosRightDown.position, Quaternion.identity);
    }

    void SpawnFromEitherLeftOrRight()
    {
        int index = Random.Range(0, 2);

        switch (index)
        {
            case 0:
                {
                    SpawnFromLeft();
                    break;
                }

            case 1:
                {
                    Spawn_FromRight();
                    break;
                }
        }
    }



    void SpawnCollectable()
    {
        if(FindObjectOfType<Collectable>() != null)
        {
            return;
        }
        int index = Random.Range(0, collectableSpawnPoints.Length);
        Instantiate(gemCollectable, collectableSpawnPoints[index].position, Quaternion.identity);
    }

    public void GameOver()
    {
        Invoke("SetGameOverObj", 2f);
    }

    void SetGameOverObj()
    {
        gameOverObject.SetActive(true);
    }

    void DifficultyManage()
    {
        if(RepeatDelay <= minRepeatDelay)
        {
            return;
        }
        RepeatDelay--;
        Debug.Log(RepeatDelay);
    }

}
