using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float speed;

    public enum States 
    { 
        Up, Down
    }

    [SerializeField]States state;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        switch (state) 
        {
            case States.Up:
            {
                    rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
                    break;
            }


            case States.Down:
            {

                    rb.AddForce(Vector2.down * speed, ForceMode2D.Impulse);
                    break;
            }


        }


      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
