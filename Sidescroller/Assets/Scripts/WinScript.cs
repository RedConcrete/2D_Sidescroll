using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WinScript : MonoBehaviour
{
    public GameObject gameObject;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals(gameObject.name))
        {
            print("A new Tamtung with Adroid!");
        }
       
    }
}
