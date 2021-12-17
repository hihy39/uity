using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    public Transform pos;
    public float cooltime;
    private float curtime;

    Rigidbody2D rb;

    int playerLayer, groundLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        playerLayer = LayerMask.NameToLayer("Player");
        groundLayer = LayerMask.NameToLayer("Ground");
    }
    void Update()
    {
        if (curtime <= 0)
        {
            if (Input.GetKey(KeyCode.A))
            {
                Instantiate(bullet, pos.position, transform.rotation);
            }
            curtime = cooltime;
        }
        curtime -= Time.deltaTime;
    }

}
