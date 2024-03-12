using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class obstacles : MonoBehaviour
{ 
    
    
    public GameObject checkObstacleObj,hitRayObj;
    public RaycastHit2D checkObstacleRay;
    
    public Vector3 hitObjHeight ;
    public BoxCollider2D collObj;
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
        
       
        

        if(checkObstacleRay){
            
        
            hitRayObj = checkObstacleRay.collider.gameObject;//ASIGNA EL TRANSFORM DEL OBJETO QUE ESTA TOCANDO EL RAYCAST
            collObj = hitRayObj.transform.GetComponent<BoxCollider2D>();

            hitObjHeight = collObj.bounds.size;


            //checkObstacleObj.transform.position = new Vector3(checkObstacleObj.transform.position.x,hitObjHeight.y,0);
            Debug.DrawRay(checkObstacleObj.transform.position,checkObstacleObj.transform.right * distRayObstacle,Color.yellow);
            Debug.Log("SIZE: " + hitObjHeight.y);
                       
            obstacleAction();
        }else{
            hitRayObj = null;
            collObj = null;
        }
    }

    public void obstacleAction(){


        if(Input.GetKeyDown(KeyCode.Space)){
            transform.DOMove(new Vector3(checkObstacleRay.point.x,transform.position.y + hitRayObj.transform.localScale.y,0),20f * Time.deltaTime);
        }
    }


}
