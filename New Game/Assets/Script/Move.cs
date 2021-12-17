using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector2 speed_vec;

    void Start()
    {

    }

    void Update()
    {
        speed_vec = Vector2.zero;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed_vec.x += 0.1f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed_vec.x += -0.1f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed_vec.y += 0.1f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            speed_vec.y += -0.1f;
        }
        transform.Translate(speed_vec);
    }
}
