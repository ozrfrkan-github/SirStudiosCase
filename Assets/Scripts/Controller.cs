using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private FloatingJoystick _joystick;
    [SerializeField] private float playerSpeed;

    private float rotY;
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rotY = _joystick.Horizontal * 3f;
            transform.rotation = Quaternion.Slerp(transform.rotation, 
                Quaternion.Euler(0, transform.eulerAngles.y + rotY, 0), .25f);

            transform.Translate(transform.forward * playerSpeed, Space.World);
        }
    }
}