using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    public enum states
    {
        up, down, left, right
    }

    public states state;

    [SerializeField] Player player;

    private void OnMouseDown()
    {
        switch (state)
        {
            case states.up:
            {
                    player.KeypadUp();
                    break;
            }

            case states.down:
            {
                    player.KeypadDown();
                    break;
            }

            case states.left:
            {
                    player.KeypadLeft();
                    break;
            }

            case states.right:
            {
                    player.KeypadRight();
                    break;
            }
        }
    }

}
