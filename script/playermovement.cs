using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {

    internal static bool enable;
    public Rigidbody rb;
    public float forwardforce;
    public bool Grounded = true;
    public float speed;


    void Start()
    {
        FindObjectOfType<audiomanager>().Play("movement fx");
        // FindObjectOfType<audiomanager>().Play("Background music");
    }

    // if u are adding a phy object make sure you use fixedupdate
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        TouchMove();
    }

    void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);

            if(mousePos.x > 0.5f)
            {
                //Move Right
               transform.Translate(speed*Time.deltaTime,0,0);
            }
            else
            {
                //Move left
                transform.Translate(-speed*Time.deltaTime,0,0);
            }
        }
    } 

    
}
