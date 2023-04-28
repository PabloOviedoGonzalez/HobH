using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] private Transform Controladordisparo;
    [SerializeField] private GameObject bala;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Disparar
            Disparar();
        }
    }

    private void Disparar()
    {
        Instantiate(bala, Controladordisparo.position, Controladordisparo.rotation);
    }
}

