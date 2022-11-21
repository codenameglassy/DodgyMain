using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpawner : MonoBehaviour
{
    [SerializeField] GameObject fireball;

    [SerializeField] Transform spawnPosLeft;
    [SerializeField] Transform spawnPosMid;
    [SerializeField] Transform spawnPosRight;

    [SerializeField] float startDelay, repeatDelay;

    [SerializeField] Transform top1, top2, top3;
    [SerializeField] Transform mid1, mid2, mid3;
    [SerializeField] Transform last1, last2, last3;

    public Transform currentTarget;

    private void Start()
    {
        InvokeRepeating("SpawnIt", startDelay, repeatDelay);
    }

    void SpawnIt()
    {
        int random = Random.Range(1, 4);

        if(random == 1)
        {
            SpawnLeft();
            return;
        }

        if (random == 2)
        {
            SpawnMid();
            return;
        }

        if (random == 3)
        {
            SpawnRight();
            return; 
        }
    }



    void SpawnLeft()
    {
        Instantiate(fireball, spawnPosLeft.position, Quaternion.identity);
        currentTarget = mid1;
    }

    void SpawnMid()
    {
        Instantiate(fireball, spawnPosMid.position, Quaternion.identity);
        currentTarget = mid2;
    }

    void SpawnRight()
    {
        Instantiate(fireball, spawnPosRight.position, Quaternion.identity);
        currentTarget = mid3;
    }

}
