using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookHor : MonoBehaviour
{
    public float speed = 9.0f;

    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * speed, 0);
    }
}
