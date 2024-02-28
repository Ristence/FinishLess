using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class hookMode : MonoBehaviour
{
    public bool hookModo;
    public Pj character;
    public Hook_Script hook_Script;

    public Rigidbody2D hook_Obj_Rb;
    public Vector2 mousePos, rayHit, dir;
    public GameObject grapObj, hook_Start_Obj, hook_Obj;
    //public DistanceJoint2D joinPoint;
    
    public RaycastHit2D hookRay;
    public float distRay, hook_Shoot_Force, distPj_hook;
  


    // Start is called before the first frame update
    void Start()
    {
        hookModo = false;
        distRay = 30f;
        hook_Shoot_Force = 100;
        //joinPoint.autoConfigureDistance = false;
        //joinPoint.enabled = false;
        DOTween.Init();
        hook_Obj_Rb.bodyType = RigidbodyType2D.Kinematic;
    }

  

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse2)){//CLICK_RUEDA_RATON
            hookModo = true;                       
        }
        if(hookModo){
            hookFunction();
        }
        if(Input.GetKeyDown(KeyCode.Mouse1)){//CLICK_DERECHO - ENTRA AL HOOK MODE
            hookModo = false;//ENTRA AL HOOK_MODE
            hook_Obj.transform.position = hook_Start_Obj.transform.position;//POSICION DEL HOOK VUELVE A LA POSICION DE PARTIDA SI CLICK_DERECHO
            //Debug.Log("TOCO");
            //joinPoint.enabled = false;
        }

        
    }

      public void hookFunction(){


        dir = (grapObj.transform.position - hook_Start_Obj.transform.position).normalized;//DISTANCIA ENTRE EL PJ Y HOOK(apuntado)

        distPj_hook = Vector2.Distance(character.transform.position, hook_Obj.transform.position);//SOLO VER SI FUNCIONA LA DISTANCIA
        //Debug.Log(distPj_hook);//SOLO VER SI FUNCIONA LA DISTANCIA

        hookRay = Physics2D.Raycast(hook_Start_Obj.transform.position,dir,distRay);
        if(hookRay){
            //Debug.Log("toco");
        }
        

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//POSICION DEL MOUSE EN LA PANTALLA

        Debug.DrawRay(hook_Start_Obj.transform.position,dir * distRay ,Color.white);

        grapObj.transform.position = new Vector2(mousePos.x,mousePos.y);

        if(Input.GetKeyDown(KeyCode.Mouse0)){//CLICK_IZQUIERDO            
            rayHit = hookRay.point;
            hook_Obj_Rb.bodyType = RigidbodyType2D.Dynamic;
            hook_Obj_Rb.AddForce(dir * hook_Shoot_Force * Time.deltaTime,ForceMode2D.Impulse);

        }else if(hookModo){



            //joinPoint.enabled = false;
            
        }

    }
}
