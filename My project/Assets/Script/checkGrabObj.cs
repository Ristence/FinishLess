using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

using DG.Tweening;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Vector2 = UnityEngine.Vector2;


public class checkGrabObj : MonoBehaviour {

    public backpackLogic backpackLogics;
    public Collider2D grabObj;
    public GameObject handF;
    
     
    void Start() {
        
    }

    void Update() {
        
    }


    private void OnTriggerStay2D(Collider2D other) {
    
        if(other.gameObject.tag == "GrabObj" && Input.GetKey(KeyCode.Mouse0) ){

            try{
                grabObj = other;
           

            }catch(Exception e){

            }   
            
            grabObj.GetComponent<Rigidbody2D>().isKinematic = true;
            //grabObj.transform.parent = handF.transform;
            grabObj.transform.position = handF.transform.position;
        }/* else if(other.gameObject.tag == "GrabObj" && !Input.GetKey(KeyCode.Mouse0) && backpackLogics){
            grabObj.GetComponent<Rigidbody2D>().isKinematic = false;
        } */
    }  

     

    private void OnTriggerExit2D(Collider2D other) {
        grabObj = null;
        //grabObj.GetComponent<Rigidbody2D>().isKinematic = false;
    } 



}
