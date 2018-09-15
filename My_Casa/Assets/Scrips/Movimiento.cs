using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public bool canX;
    public float speed_X;
    public float amount_x;
    float m_internal_amount_x;
    public bool right;

    public bool canY;
    public float speed_Y;
    public float amount_y;
    float m_internal_amount_y;
    public bool up;

    public bool canZ;
    public float speed_Z;
    public float amount_z;
    float m_internal_amount_z;
    public bool forward;

    
    void Start()
    {
        m_internal_amount_x = amount_x;
        m_internal_amount_y = amount_y;
        m_internal_amount_z = amount_z;
    }
    private void Update()
    {
        if (canX)
        {
            MoveX();

        }

        if (canY)
        {
            MoveY();
        }

        if (canZ)
        {
            MoveZ();

        }
    }
    void MoveZ()
    {
        if (forward)
        {
            transform.Translate(Vector3.forward * (speed_Z * Time.deltaTime), Space.Self);
            amount_z -= Time.deltaTime;
            if (amount_z < m_internal_amount_z * -1)
            {
                forward = false;
            }
        }
        else
        {
            transform.Translate(Vector3.back * (speed_Z * Time.deltaTime), Space.Self);
            amount_z += Time.deltaTime;
            if (amount_z > m_internal_amount_z)
            {
                forward = true;

            }
        }
        
    }   

    void MoveY()
    {
        if (up)
        {
            transform.Translate(Vector2.up * (speed_Y * Time.deltaTime), Space.Self);
            amount_y -= Time.deltaTime;
            if (amount_y < m_internal_amount_y * -1)
            {
                up = false;
            }
        }
        else
        {
            transform.Translate(Vector2.down * (speed_Y * Time.deltaTime), Space.Self);
            amount_y += Time.deltaTime;
            if (amount_y > m_internal_amount_y)
            {
                up = true;
            }
        }
    }




    void MoveX()

    {
        if (right)
        {
            transform.Translate(Vector3.right * (speed_X * Time.deltaTime), Space.Self);
            amount_x -= Time.deltaTime;
            if (amount_x < m_internal_amount_x * -1)
            {
                right = false;
            }



        }
        else
        {
            transform.Translate(Vector3.left * (speed_X * Time.deltaTime), Space.Self);
            amount_x += Time.deltaTime;
            if (amount_x > m_internal_amount_x)
            {
                right = true;
            }
        }

    }


}



















































   