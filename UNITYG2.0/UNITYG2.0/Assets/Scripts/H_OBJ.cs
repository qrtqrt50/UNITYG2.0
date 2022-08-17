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
        yield return new WaitForSeconds(2.0f);
        //Later...

        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }
}
