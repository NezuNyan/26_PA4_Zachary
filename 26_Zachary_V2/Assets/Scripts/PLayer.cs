using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer : MonoBehaviour
{
    Rigidbody rb;

    public float speed;
    public float rotationspeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertmove = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float hormove = Input.GetAxis("Horizontal") * rotationspeed *Time.deltaTime;

        transform.Translate(hormove, 0, vertmove);

    }
}
