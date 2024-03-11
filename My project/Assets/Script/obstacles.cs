using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class obstacles : MonoBehaviour
{ 
    
    
    public GameObject checkObstacleObj;
    public RaycastHit2D checkObstacleRay;
    public Transform hitRayObj;
    public float distRayObstacle;
    public LayerMask obstacleLayer;
    


    // Start is called before the first frame update
    void Start()
    {
        obstacleLayer = LayerMask.GetMask("Obstacles");
        distRayObstacle = 3f;
        DOTween.Init();
    }

    // Update is called once per frame
    void Update()
    {
        isObstacle();
    }

    public void isObstacle(){

        checkObstacleRay = Physics2D.Raycast(checkObstacleObj.transform.position,checkObstacleObj.transform.right,distRayObstacle,obstacleLayer);//CHOCA CON EL OBSTACULO
        
        try {
            hitRayObj = checkObstacleRay.transform.GetComponent<Transform>();//ASIGNA EL TRANSFORM DEL OBJETO QUE ESTA TOCANDO EL RAYCAST
        }
        catch (Exception e) {
        
        } 

        

        if(checkObstacleRay){
            
            checkObstacleObj.transform.position = new Vector3(checkObstacleObj.transform.position.x,hitRayObj.position.y,0);

            Debug.DrawRay(checkObstacleObj.transform.position,checkObstacleObj.transform.right * distRayObstacle,Color.yellow);
            Debug.Log( "checkObstacleObj: " + checkObstacleObj.transform.position);
            obstacleAction();
        }else{

        }
    }

    public void obstacleAction(){


        if(Input.GetKeyDown(KeyCode.Space)){
            transform.DOMove(new Vector3(checkObstacleRay.point.x,transform.position.y + hitRayObj.localScale.y,0),10f * Time.deltaTime);
        }
    }


}
