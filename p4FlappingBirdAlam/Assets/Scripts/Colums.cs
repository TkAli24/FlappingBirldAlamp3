using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colums : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D othere)
    {
        GameControl.instrance.BirdScored();
    }
}
