using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player_H : MonoBehaviour
{
    public Slider SB;
    public int H = 100;



    private void Start()
    {
        SB = GetComponent<Slider>();
        SB.value = H;
    }



    public void T_D(int D)
    {
        H -= D;

        if (H <= 0)
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
