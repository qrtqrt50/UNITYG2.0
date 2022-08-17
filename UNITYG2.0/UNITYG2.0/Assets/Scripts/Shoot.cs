using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public static int D = 10;
    public Transform Fire_Position;
    public GameObject Fire_OBJ;




    private void Update()
    {
        
    }



    public void Fire(InputAction.CallbackContext CON)
    {
        if (CON.performed)
        {
            Do_It();
        }

        if (CON.canceled)
        {
            
        }
    }

    void Do_It()
    {
        Instantiate(Fire_OBJ, Fire_Position.position, Fire_Position.rotation);
    }
}