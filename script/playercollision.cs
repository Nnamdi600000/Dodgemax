using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class playercollision : MonoBehaviour {
    // code for player collision
    public playermovement movement;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle") 
        {
            movement.enabled = false; // to disable movement

            FindObjectOfType<Gamemanager>().loseui();

            FindObjectOfType<audiomanager>().Play("Collision fx");

            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
        }
        
    }
}
