using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkObstacle : MonoBehaviour
{

     public LayerMask obstacleLayer;
     public Collider2D collObj;
     
    // Start is called before the first frame update
    void Start()
    {
        obstacleLayer = LayerMask.GetMask("Obstacles");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerStay2D(Collider2D other) {
        
        try{
            
            if(other.gameObject.tag == "Collisionable"){
            
                collObj = other;
            }

        }catch(Exception e){

        }       
    }
     private void OnTriggerExit2D(Collider2D other) {
            collObj = null;
     }
}
