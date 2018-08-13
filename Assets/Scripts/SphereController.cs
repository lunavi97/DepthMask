using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour {

    private Rigidbody rb;
    private enum Direction
    {
        Up,
        Right,
        Down,
        Left
    };
    public float acceleration;
    
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        int num = (int)Random.Range((int)Direction.Up, (int)Direction.Left + 1);
        
        if (num == (int)Direction.Up) {
            rb.AddForce(0, 0, acceleration);
        }

        else if (num == (int)Direction.Right)
        {
            rb.AddForce(acceleration, 0, 0);
        }

        else if (num == (int)Direction.Down)
        {
            rb.AddForce(0, 0, -acceleration);
        }

        else
        {
            rb.AddForce(-acceleration, 0, 0);
        }
	}
}
