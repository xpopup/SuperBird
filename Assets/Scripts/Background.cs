using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed = 3;
    public float Size = 20.48f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ω√¿€");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        if (transform.position.x < -Size)
        {
            transform.Translate(new Vector3(Size * 2, 0, 0));
        }
    }
}
