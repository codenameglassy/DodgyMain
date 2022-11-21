using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Node currentNode;

    private void Start()
    {
        transform.position = currentNode.gameObject.transform.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if(currentNode.down != null)
            {
                transform.position = currentNode.down.gameObject.transform.position;
                currentNode = currentNode.down.GetComponent<Node>();
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (currentNode.up != null)
            {
                transform.position = currentNode.up.gameObject.transform.position;
                currentNode = currentNode.up.GetComponent<Node>();
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (currentNode.left != null)
            {
                transform.position = currentNode.left.gameObject.transform.position;
                currentNode = currentNode.left.GetComponent<Node>();
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (currentNode.right != null)
            {
                transform.position = currentNode.right.gameObject.transform.position;
                currentNode = currentNode.right.GetComponent<Node>();
            }
        }
    }
}
