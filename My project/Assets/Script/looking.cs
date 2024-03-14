using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using Vector2 = UnityEngine.Vector2;
using UnityEditor;
using DG.Tweening;

public class looking : MonoBehaviour
{

    public Vector2 mousePos;
    public Transform armFSolver, armBSolver;

  
    public Transform sight, ikArmF, ikArmB;
    public GameObject main_Camara;
    
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        main_Camara.transform.position = new Vector3(transform.position.x,transform.position.y, -10);

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        sight.position = new Vector2(mousePos.x,mousePos.y);

        ArmIkFunction() ;

        //ikArmB.position = sight.position;
        
       
    }

    public void ArmIkFunction(){

        
        if(Input.GetKey(KeyCode.Mouse0)){
            ikArmF.DOMove(sight.position,1);
        }else{
            ikArmF.DOMove(armFSolver.position,1);
        }
        
        
        if(Input.GetKey(KeyCode.Mouse1)){
            ikArmB.DOMove(sight.position,1);
        }else{
            ikArmB.DOMove(armBSolver.position,1);
        }




    }

}
