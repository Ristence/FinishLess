using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class obstacles : MonoBehaviour
{ 
    
    
    public GameObject checkObstacle;
    public RaycastHit2D checkObstacleRay;
    public Transform hitRayObj;
    public float distRayObstacle;
    public LayerMask obstacleLayer;
    


    // Start is called before the first frame update
    void Start()
    {
        obstacleLayer = LayerMask.GetMask("Obstacles");
        distRayObstacle = 3;
        DOTween.Init();
    }

    // Update is called once per frame
    void Update()
    {
        isObstacle();
    }

    public void isObstacle(){

        checkObstacleRay = Physics2D.Raycast(checkObstacle.transform.position,checkObstacle.transform.right,distRayObstacle,obstacleLayer);//CHOCA CON EL OBSTACULO
        hitRayObj = checkObstacleRay.transform.GetComponent<Transform>();//ASIGNA EL TRANSFORM DEL OBJETO QUE ESTA TOCANDO EL RAYCAST
        if(checkObstacleRay && Input.GetKeyDown(KeyCode.Space)){
            Debug.DrawRay(transform.position,checkObstacle.transform.right,Color.gray);
            Debug.Log(hitRayObj.localScale);
            obstacleAction();
        }else{

        }
    }

    public void obstacleAction(){

        transform.DOMove(new Vector3(checkObstacleRay.point.x,transform.position.y + hitRayObj.localScale.y,0),10f * Time.deltaTime);


    }


}
