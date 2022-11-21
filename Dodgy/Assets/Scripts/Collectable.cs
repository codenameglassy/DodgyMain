using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] GameObject vfxPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<RamailoGamesScoreManager>().AddScore(1f);
            Instantiate(vfxPrefab, transform.position, Quaternion.identity);
            AudioManagerCS.instance.Play("collectable");
            Destroy(gameObject);
        }
    }
}
