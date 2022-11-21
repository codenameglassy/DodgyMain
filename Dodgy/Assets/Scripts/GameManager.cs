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



    [SerializeField] int maxPos;
    [SerializeField] float startDelay, RepeatDelay;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        InvokeRepeating("Spawn", startDelay, RepeatDelay);
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

}
