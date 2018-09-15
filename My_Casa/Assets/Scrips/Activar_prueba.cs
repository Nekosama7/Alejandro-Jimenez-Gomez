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

    private void OnTriggerEnter(Collider plataforma_prueba_2)
    {
        if(plataforma_prueba_2.transform.tag == "Player")
        {
            prueba_2.SetActive(true);

        }
    }


    private void OnTriggerExit(Collider plataforma_prueba_2)
    {
        if (plataforma_prueba_2.transform.tag == "Player")
        {

            prueba_2.SetActive(false);
        }

    }
}


