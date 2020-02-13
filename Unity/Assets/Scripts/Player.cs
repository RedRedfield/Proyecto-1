using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Animator anim;
    private Vector2 move;
    public int direction;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        direction = 0;
    }

    void Update()
    {
        GetInput();
        Move();
    }

    void Move()
    {
        transform.Translate(move * speed * Time.deltaTime);
    }

    void GetInput()
    {
        
        move = Vector2.zero;
        speed = 1f;
        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.LeftShift))
                speed = 2;
            direction = 0;
            anim.SetInteger("direction", direction);
            move += Vector2.down;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
                speed = 2;
            direction = 1;
            anim.SetInteger("direction", direction);
            move += Vector2.up;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
                speed = 2;
            direction = 2;
            anim.SetInteger("direction", direction);
            move += Vector2.right;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.LeftShift))
                speed = 2;
            direction = 3;
            anim.SetInteger("direction", direction);
            move += Vector2.left;
        }
    }

}

/*
    [SerializeField]
    private float speed;
    private Animator anim;
    private Vector2 direccion;
    //public int direction;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //direction = 0;
    }

    // Update is called once per frame

    void Update()
    {
        GetInput();
        Move();
    }

    void Move()
    {
        transform.Translate(direccion*speed*Time.deltaTime); 
    }

    void GetInput()
    {
        direccion = Vector2.zero;
        if (Input.GetKeyDown(KeyCode.S))
        {
            //direction = 0;
            //anim.SetInteger("direction", direction);
            direccion += Vector2.down;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //direction = 1;
            //anim.SetInteger("direction", direction);
            direccion += Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //direction = 2;
            //anim.SetInteger("direction", direction);
            direccion += Vector2.right;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //direction = 3;
            //anim.SetInteger("direction", direction);
            direccion += Vector2.left;
        }
    }
 */
