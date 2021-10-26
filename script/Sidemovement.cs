using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sidemovement : MonoBehaviour
{
     internal static bool enable;
    public GameObject character;
    private Rigidbody characterBody;
     public float sideSpeed;
    private float ScreenWidth;
     public bool Grounded = true;

    // Start is called before the first frame update
    void Start()
    {
         ScreenWidth = Screen.width;
        characterBody = character.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
         int i = 0;
         //loop over every touch found
         while (i < Input.touchCount)
         {
             if (Input.GetTouch (i).position.x > ScreenWidth / 2)
             {
                //move right
                RunCharacter (1.0f);
             }
             if(Input.GetTouch (i).position.x < ScreenWidth / 2)
             {
                //move left
                RunCharacter (-1.0f);
             }
             ++i;
         }
    }

    void FixedUpdate() 
    {
        #if UNITY_EDITOR
        RunCharacter(Input.GetAxis("Horizontal"));
        #endif
    }

     public void RunCharacter(float horizontalInput)
     {
        //move player
        characterBody.AddForce(new Vector3(horizontalInput * sideSpeed * Time.deltaTime,0,0));
     }
}
