using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    private Animator anim;
    public int direction;
    public bool kek;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        direction = 0;
        //kek = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        /*if (!kek)
            direction = direction + 1;
        if(kek)
            direction = direction - 1;
        if (direction > 4||direction < 0)
            kek = !kek;*/

        if (Input.GetKeyDown(KeyCode.S))
        {
            direction = 0;
            //transform.position = new Vector3 (0,1,0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = 1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            direction = 2;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            direction = 3;
        }

        anim.SetInteger("direction", direction);
    }
}
