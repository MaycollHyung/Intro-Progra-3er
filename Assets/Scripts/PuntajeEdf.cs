using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntajeEdf : MonoBehaviour
{
    
    [Range(0,500)][SerializeField] private float cantidadPuntos;
    [Space]
    [SerializeField] private Puntaje puntaje;

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            puntaje.sumarPuntaje(cantidadPuntos);
            
        }
    }
}
