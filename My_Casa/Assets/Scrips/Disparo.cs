using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject pref_bala;
    GameObject bala;

    public Transform spawnPoint;
    public float force;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shot();
        }
    }

    void Shot()
    {
        bala = Instantiate(pref_bala, spawnPoint.position, Quaternion.identity);
        bala.AddComponent<Rigidbody>();
        bala.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * force, ForceMode.Impulse);
        Destroy(bala, 5f);
    }
}



