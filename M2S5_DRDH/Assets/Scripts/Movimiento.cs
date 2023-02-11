using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Vector2 velocity;
    public GameObject soltar;
    int n;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
    }


    public void Derecha()
    {
         velocity.x = 1;
    }

    public void Izquierda()
    {
        velocity.x = -1;
    }
    public void Alto()
    {
        velocity.x = 0;
    }

    public void suelta()
    {
        n = 1;
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        if (n != 1)
        {
            rb2d.MovePosition(rb2d.position + velocity * Time.fixedDeltaTime);
        }
    }
}
