using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar_prueba : MonoBehaviour
{
    public GameObject prueba_2;


    private void Start()
    {
        prueba_2.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            prueba_2.SetActive(true);

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {

            prueba_2.SetActive(false);
        }

    }
}


