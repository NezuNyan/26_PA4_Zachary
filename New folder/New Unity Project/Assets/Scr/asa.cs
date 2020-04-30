using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asa : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float forward = Input.GetAxis("Vertical") * 3 * Time.deltaTime;
        float side = Input.GetAxis("Horizontal") * 3 * Time.deltaTime;

        transform.Translate(side, 0, forward);

    }
}
