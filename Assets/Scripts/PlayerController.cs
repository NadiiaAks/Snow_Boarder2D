using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float torqueAmount = 1f;
    [SerializeField] private float boostSpeed = 30f;
    [SerializeField] private float normalSpeed = 20f;

    Rigidbody2D rb;
    SurfaceEffector2D effector;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        effector = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        RotatePlayer();
        BoostSpeed();
    }

    void BoostSpeed()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            effector.speed = boostSpeed;
        }
        else
        {
            effector.speed = normalSpeed;
        }

    }
    void RotatePlayer()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torqueAmount);
        }
    }

}
