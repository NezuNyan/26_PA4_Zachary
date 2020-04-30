using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private Vector3 target = new Vector3(0f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target, Vector3.up, 1000 * Time.deltaTime);
    }
}