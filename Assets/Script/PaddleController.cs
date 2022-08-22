using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey; 

    private Rigidbody2D rig; 

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();        
    }

    void Update()
    {
        MoveObject(GetInput());
    }

    Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            //gerakan ke atas
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            //gerakan ke bawah
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    void MoveObject(Vector2 movement)
    {
        // Gerakan object pake input
        rig.velocity = movement;
    }
}
