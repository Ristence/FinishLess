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
        if(other.gameObject.tag == "Collisionable"){
                     
                collObj = other;        
            
        }       
    }
     private void OnTriggerExit2D(Collider2D other) {
            try{  
            collObj = null;
            }catch(Exception e){
                
            }
     }
}
