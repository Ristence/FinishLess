using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using Vector2 = UnityEngine.Vector2;
using DG.Tweening;

public class Pj : MonoBehaviour
{

    public Rigidbody2D rb;
    public Hook_Script hook_Script;
    public obstacles obstacles_Script;
    public checkObstacle checkObstacles;
    public Animator pjAnim;
    public GameObject pj;
    public checkGround checkGround;

    private float walkSpeed, runSpeed;
    private float jumpSpeed = 40;
    public float gravity = 5;
    public float gravityInFall = 15;

    
   


    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       DOTween.Init();
       walkSpeed = 1000f;
       runSpeed = 2500f;
       
    } 

    


    // Update is called once per frame
    void Update()
    {
        float movH = Input.GetAxis("Horizontal") * Time.deltaTime;
        float movV = Input.GetAxis("Vertical") * Time.deltaTime;

        if(Input.GetKey(KeyCode.LeftShift)){
            rb.velocityX = movH * runSpeed;
        }else{
            rb.velocityX = movH * walkSpeed;
        }
            
       

        if(movH < 0){
            //Derecha
            transform.eulerAngles = new Vector3(0,180);
            pjAnim.SetBool("Walk",true);
        }else if (movH > 0){
            //Izquierda
            transform.eulerAngles = new Vector3(0,0);
            pjAnim.SetBool("Walk",true);
        }else{
            pjAnim.SetBool("Walk",false);
        }

        if(movV == 0){
            //Abajo
            rb.AddForce(Vector2.down * Time.deltaTime);           
        }
        if(Input.GetKeyDown(KeyCode.Space) && checkGround.checkGroundRay && !checkObstacles.collObj){ 
                      
           Jumping();
        }

        if(rb.velocityY > 0){
            rb.gravityScale = gravity;

        }   else{
            rb.gravityScale = gravityInFall;
        }     
    }

    public void Jumping () {
         rb.AddForce(Vector2.up * jumpSpeed ,ForceMode2D.Impulse);
    }
    
    private void OnCollisionStay2D(Collision2D other) {    

		if (other.gameObject.tag == "Chain" && Input.GetKeyDown(KeyCode.E)) 
		{
            transform.parent = other.transform;
            rb.bodyType = RigidbodyType2D.Kinematic;
            Debug.Log("ajhsgas");

		}
	}
    
}
