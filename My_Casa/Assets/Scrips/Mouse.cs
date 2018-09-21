using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Mouse : MonoBehaviour
{
    public float velocidad;
    public float rotateSpeed = 3.0f;
    CharacterController controller;

    public GameObject cam;
    public float rot_x;


    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Movimiento();
    }

    public void Movimiento()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotateSpeed, 0);

        //can.transform.Rotate(Input.GetAxis("Mouse Y") *-1, 0, 0);
        rot_x += (Input.GetAxis("Mouse Y") * -1) * rotateSpeed;

        if (rot_x > 0 && rot_x < 60)
        {
            cam.transform.localRotation = Quaternion.Euler(rot_x, 0, 0);
        }
        if (rot_x < 0 && rot_x > -60)
        {
            cam.transform.localRotation = Quaternion.Euler(rot_x, 0, 0);
        }
        if (rot_x > 60)
        {
            rot_x = 60;
        }
        if (rot_x < -60)
        {
            rot_x = -60;
        }

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = velocidad * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);
    }
}



