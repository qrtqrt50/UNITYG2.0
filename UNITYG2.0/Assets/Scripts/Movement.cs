using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int J_Force;
    private bool IS_J;
    private Rigidbody2D Rigidbody_2D;

    private void Start()
    {
        IS_J = false;
    }

    private void Awake()
    {
        Rigidbody_2D = GetComponent<Rigidbody2D>();
    }

    public void jump(InputAction.CallbackContext CON)
    {
        if (IS_J == true)
        {
            Debug.Log($"JUMP! {CON.phase}");
            Rigidbody_2D.AddForce(Vector3.up * J_Force, ForceMode2D.Impulse);
        }
    }
}
