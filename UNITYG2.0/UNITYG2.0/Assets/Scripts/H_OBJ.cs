using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_OBJ : MonoBehaviour
{
    public int H = 100;



    public void T_D(int D)
    {
        H -= D;

        if(H <= 0)
        {
            StartCoroutine(OVER());
        }
    }



    IEnumerator OVER()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
