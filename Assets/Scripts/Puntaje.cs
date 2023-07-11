using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    float puntos;
    TextMeshProUGUI textMesh;
    
   

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
       
       
    }

    // Update is called once per frame
    void Update()
    {
        puntos += Time.deltaTime;
        textMesh.text = puntos.ToString("0");
    }

    public void sumarPuntaje(float puntosEntrada)
    {
        puntos += puntosEntrada;

       
    }
    
    private void Savepoint()
    {
        PlayerPrefs.SetFloat("puntos", puntos);
    }
}
