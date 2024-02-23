using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook_Script : MonoBehaviour
{

    public hookMode hookMode_Sp;
    public SpriteRenderer hook_Red_sR,hook_Green_sR;



    // Start is called before the first frame update
    void Start()
    {
        //hook_Red_sR = Resources.Load("Resources/Srites/HookRed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Collisionable") 
		{
            Debug.Log("TOCOQLO");

            hookMode_Sp.hook_Obj_Rb.bodyType = RigidbodyType2D.Static;
			//hookMode_Sp.hook_Obj.transform.position = hookMode_Sp.rayHit;

		}
	}
}
