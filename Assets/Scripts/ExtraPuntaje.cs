using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraPuntaje : MonoBehaviour
{
    
    [SerializeField] [Range(0, 1000)] private float cantidadPuntos;
    [Space]
    [SerializeField] private Puntaje puntaje;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            puntaje.sumarPuntaje(cantidadPuntos);

            
        }
        Destroy(gameObject);   
    }
}
