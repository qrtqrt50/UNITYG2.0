using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D RB_2D;
    public Transform See_G;
    public LayerMask Ground;



    private float HOR;
    private float SPEED = 5f;
    private float JUMP = 10f;
    private bool IS_RIGHT = true;



    private void FixedUpdate()
    {
        RB_2D.velocity = new Vector2(HOR * SPEED, RB_2D.velocity.y);

        if (!IS_RIGHT && HOR > 0f)
        {
            Flip();
        }
        else if (IS_RIGHT && HOR < 0f)
        {
            Flip();
        }
    }



    private bool IS_GROUND()
    {
        return Physics2D.OverlapCircle(See_G.position, 0.2f, Ground);
    }

    private void Flip()
    {
        IS_RIGHT = !IS_RIGHT;
        transform.Rotate(0, -180, 0);
    }



    public void Move(InputAction.CallbackContext CON)
    {
        HOR = CON.ReadValue<Vector2>().x;
    }

    public void Jump(InputAction.CallbackContext CON)
    {
        if (CON.performed && IS_GROUND())
        {
            RB_2D.velocity = new Vector2(RB_2D.velocity.x, JUMP);
        }

        if (CON.canceled && RB_2D.velocity.y > 0f)
        {
            RB_2D.velocity = new Vector2(RB_2D.velocity.x, RB_2D.velocity.y * 0.5f);
        }
    }
}