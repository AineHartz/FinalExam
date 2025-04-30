using System;
using UnityEngine;

public class NoteScript : MonoBehaviour
{

    private float total_move = 5.0f;
    private float moved = 0.0f;
    private bool positive = true;
    public Rigidbody2D body;
    private float lowerPos = 72;
    private float upperPos = 76;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (positive)
        {
            body.MovePosition(new Vector2(body.position.x, lowerPos));

            //transform.position.Set(transform.position.x, transform.position.y - 0.1f, transform.position.z);
            //moved += 0.1f;
        }

        if (!positive)
        {
            body.MovePosition(new Vector2(body.position.x, upperPos));


            //transform.position.Set(transform.position.x, transform.position.y + 0.1f, transform.position.z);
            //moved += 0.1f;
        }
        /*
        if (moved == total_move)
        {
            moved = 0.0f;
            positive = !positive;
        }
        */

        if((body.position.y == lowerPos) || (body.position.y == upperPos))
        {
            positive = !positive;
        }
    }
}
