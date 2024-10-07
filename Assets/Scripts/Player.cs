using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float gravity = 10f;
    public float accel = 10f;
    float v;
    // Start is called before the first frame update
    void Start()
    {
        v = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            v  -= accel * Time.deltaTime;
        }
        else
        {
            v += gravity * Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector2.down * v * Time.fixedDeltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ãæµ¹");
    }

}
