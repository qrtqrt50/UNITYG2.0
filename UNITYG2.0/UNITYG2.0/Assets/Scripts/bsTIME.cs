using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bsTIME : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D RB;

    void Start()
    {
        RB.GetComponent<Rigidbody2D>();
        RB.velocity = transform.right * Speed;

        StartCoroutine(Wait());
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        H_OBJ _OBJ_ = collision.gameObject.GetComponent<H_OBJ>();
        if (_OBJ_ != null)
        {
            _OBJ_.T_D(Shoot.D);
        }

        StartCoroutine(Wait());
    }



    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2.0f);
        RB.gravityScale = 1;

        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }
}
