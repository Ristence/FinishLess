using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{ 
    
    
    public GameObject checkObstacle;
    public bool checkObstacleRay;
    public float distRayObstacle;
    public LayerMask obstacleLayer;


    // Start is called before the first frame update
    void Start()
    {
        obstacleLayer = LayerMask.GetMask("Obstacles");
        distRayObstacle = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void isObstacle(){

        checkObstacleRay = Physics2D.Raycast(checkObstacle.transform.position,checkObstacle.transform.right,distRayObstacle,obstacleLayer);
        if(checkObstacleRay){
            Debug.DrawRay(transform.position,checkObstacle.transform.right,Color.black);
            
        }else{

        }
    }
}
