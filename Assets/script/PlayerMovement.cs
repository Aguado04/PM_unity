using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2;
    public KeyCode upkey, downkey, rightkey, leftkey;
    private Vector2 direccion;
    private Rigidbody2D rb; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(upkey))
        {
            //Cuando le das al botón establecido se crea un vector dirección
            direccion = new Vector2(0, 1);

        }else if (Input.GetKey(downkey))
        {
            direccion = new Vector2(0, -1); 
        }else if (Input.GetKey(rightkey))
        {

        }
        else if (Input.GetKey(leftkey))
        {

        }
    }

    void FixedUpdate()
    {
        //Modificar la velocidad física del objeto
        rb.velocity = direccion * speed;
    }
}
