using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zorra : MonoBehaviour
{
    public float speed = 3.0f;
    public float rotatespeed = 3.0f;
    CharacterController controller;
    public Animator animacion;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        animacion = GetComponent<Animator>();
    }
    void Update()
    {
        Movimiento();
    }
    // Fredy jode harto
    // Use this for initialization
    public void Movimiento()
    {
       
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotatespeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);

    }
}