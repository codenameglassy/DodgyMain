using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float speed;
    [SerializeField] GameObject explosionVfx;
    public enum States 
    { 
        Up, Down, Left, Right
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

            case States.Left:
            {

                    rb.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
                    break;
            }

            case States.Right:
            {

                    rb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
                    break;
            }


        }


      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(explosionVfx, transform.position, Quaternion.identity);
            AudioManagerCS.instance.Play("fireball");
            GameManager.instance.GameOver();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
