using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook_Script : MonoBehaviour
{
  
    public Rigidbody2D hook_Script_Rb;
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

            hook_Script_Rb.bodyType = RigidbodyType2D.Static;
            transform.parent = null;
			//hookMode_Sp.hook_Obj.transform.position = hookMode_Sp.rayHit;

		}
	}

    
	


}
