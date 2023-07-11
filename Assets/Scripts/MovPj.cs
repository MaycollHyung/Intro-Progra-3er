using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovPj : MonoBehaviour
{

    public Rigidbody2D Personaje;
    [HideInInspector] public float velocidad;
    public float fuerzaSalto;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        
        Vector2 input = new Vector2(x, 0);

        Personaje.MovePosition((Vector2)transform.position + (input * Time.fixedDeltaTime * velocidad));
     }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Personaje.AddForce(new Vector2(0, 3) * fuerzaSalto);
        }
    }
}
