using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Transform up, down, left, right;
    [SerializeField] float gizmosRadius;
    
    private void OnDrawGizmosSelected()
    {
        if(up != null)
        {
            Gizmos.DrawWireSphere(up.position, gizmosRadius);
        }

        if(down != null)
        {
            Gizmos.DrawWireSphere(down.position, gizmosRadius);
        }

        if(left != null)
        {
            Gizmos.DrawWireSphere(left.position, gizmosRadius);
        }

        if(right != null)
        {
            Gizmos.DrawWireSphere(right.position, gizmosRadius);
        }
    }
}
