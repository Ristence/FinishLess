using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backpackLogic : MonoBehaviour
{
    public checkGrabObj checkGrabObjs;
    public GameObject slot01;
    public Collider2D lastGrabOjb;
    public bool slot1Bool;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        //Debug.Log(.gameObject.tag);
    }
    
    
     
    public void slotFunction(){
        lastGrabOjb.transform.parent = slot01.transform;
        lastGrabOjb.transform.position = slot01.transform.position;
        
    } 

    private void OnTriggerStay2D(Collider2D other) {
    
        
        lastGrabOjb = other;


            if(other.gameObject.tag == "GrabObj"){
                lastGrabOjb.GetComponent<Rigidbody2D>().isKinematic = true;
                Debug.Log("akjshkjsa");
                slotFunction();

            }
    
    
    }
}
