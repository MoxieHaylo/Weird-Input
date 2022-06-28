using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float mouseCursorSpeed;


    void Update()
    {

        mouseCursorSpeed = Input.GetAxis("Mouse X") / Time.deltaTime;

        //right
        if (mouseCursorSpeed>10f&&Input.GetMouseButton(0))
        {
            Debug.Log("mouse moving right");
            transform.Translate(0.1f, 0f, 0f);
        }
        //left
        if (mouseCursorSpeed > 10f && Input.GetMouseButton(1))
        {
            Debug.Log("mouse moving left");
            transform.Translate(-0.1f, 0f, 0f);
        }
        //jump
        if (mouseCursorSpeed > 100f)
        {
            Debug.Log("mouse moving fast");
            transform.Translate(0f, 0.1f, 0f);
        }
    }
}
