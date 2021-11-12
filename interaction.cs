using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour
{
    [Header("Basic")]
    [SerializeField]private float range_of_ray = 3f;

    [Header("Door")]
    private door_interection door_script;
   

    [SerializeField]private GameObject open_text;

    
    

    // Update is called once per frame
    void Update()
    {
        

        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward,out hit,range_of_ray))
        {
            //door -------------------------------------
            if(hit.transform.tag =="door")
            {
                door_script = hit.collider.gameObject.GetComponent<door_interection>();
                
                if(door_script != null )
                {
                    
                    
                    door_script.door_work();
                }
                
            }
            
        }

        if(!Physics.Raycast(transform.position,transform.forward,out hit,range_of_ray))
        {
            
            door_script.not_door_fn();
            Debug.Log("ok");
        }

       
        

        
    }
}
