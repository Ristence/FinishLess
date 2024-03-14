using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backpackLogic : MonoBehaviour
{
    public checkGrabObj checkGrabObjs;
    public GameObject slot01;
    public BoxCollider2D slot01Coll;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter2D(Collider2D other) {
        
        if(checkGrabObjs.gameObject.tag == "BackpackSlot"){
            Debug.Log("hakjshdk");
        }
    }
}
