using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using Vector2 = UnityEngine.Vector2;
public class checkGround : MonoBehaviour
{

    public bool checkGroundRay;
    public Transform Pj;
    public float distrayGround;
    public Vector3 checkgroundPoint;
    public LayerMask groundLayer;
  


    // Start is called before the first frame update
    void Start()
    {
      distrayGround = 1.5f;
      
      groundLayer = LayerMask.GetMask("Ground");
    }

    
    // Update is called once per frame
    void Update()
    {
        isGround();
       
    }
   
    public void isGround(){
        checkGroundRay = Physics2D.Raycast(transform.position,-Pj.transform.up,distrayGround,groundLayer);

        if(checkGroundRay){
            Debug.DrawRay(transform.position,-Pj.transform.up,Color.red);
            
        }else{

        }
    }
    
}
