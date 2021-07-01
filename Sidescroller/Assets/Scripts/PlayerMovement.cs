using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {

        float vert_movement;
        float hor_movement;
        vert_movement = Input.GetAxis("Jump") * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            hor_movement = Input.GetAxis("Horizontal") * (float) (speed * 1.5) * Time.deltaTime;
        }
        else
        {
            hor_movement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        }

        transform.Translate(hor_movement, vert_movement, 0);
    }
}
