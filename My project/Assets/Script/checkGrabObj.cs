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
            
            other.GetComponent<Rigidbody2D>().isKinematic = true;
            other.transform.parent = handF.transform;
            other.transform.position = handF.transform.position;
            
        }else{
            other.transform.parent = null;
            other.GetComponent<Rigidbody2D>().isKinematic = false;

        }


    }

}

