using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    Vector3 move;
    public float speed;



    void Start()
    {
        move = Vector3.forward;

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (move.x==0)
            {
                move = Vector3.left;
            }
            else
            {
                move = Vector3.forward;
            }
        }
    }
    private void FixedUpdate()
    {
        Vector3 hareket = move * Time.deltaTime * speed;
        transform.position+= hareket;
    }

}
