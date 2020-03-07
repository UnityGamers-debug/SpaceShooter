using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    public float speed = 7f; // переменная скорости
    public float gravity = -9.8f;

    private CharacterController _controller;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed; //    Horizontal - дополнительное имя для сопоставления с клавиатурой
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 motion = new Vector3(deltaX, 0, deltaZ);
        motion = Vector3.ClampMagnitude(motion, speed);
        motion.y = gravity;
        motion *= Time.deltaTime;
        motion = transform.TransformDirection(motion);
        _controller.Move(motion);
        //transform.Translate(deltaX, 0, deltaZ);
    }
}
