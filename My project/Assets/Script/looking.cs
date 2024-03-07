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

public class looking : MonoBehaviour
{

    public Vector2 mousePos;

  
    public Transform sight, ikArmF, ikArmB;
    public GameObject main_Camara;
    
  
    
    
    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        
        main_Camara.transform.position = new Vector3(transform.position.x,transform.position.y, -10);

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        sight.position = new Vector2(mousePos.x,mousePos.y);
        ikArmF.position = sight.position;
        //ikArmB.position = sight.position;
        
       
    }

}
