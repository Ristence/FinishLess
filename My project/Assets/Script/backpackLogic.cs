using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backpackLogic : MonoBehaviour
{
    public checkGrabObj checkGrabObjs;
    public GameObject slot01;

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
        checkGrabObjs.transform.position = slot01.transform.position;
    } 

    private void OnTriggerStay2D(Collider2D other) {
    
            if(other.gameObject.tag == "GrabObj"){

                Debug.Log("akjshkjsa");
                slotFunction();

            }
    
    
    }
}
