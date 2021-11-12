using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class movement : MonoBehaviour
{
    [Header("Basic Needs")]
    [SerializeField]private CharacterController controler_player;
    
    [Header("Values")]
    [Range(0f,6f)]
    [SerializeField]private float spped = 3f;
    
    [SerializeField]private float jump_height;

    [Header("Gravity")]
    [SerializeField]private float gravity = -9.18f;
    Vector3 velocity_for_y;
    [SerializeField]private Transform ground_check;
    [SerializeField]private float sphere_distance = 0.4f;
    [SerializeField]private LayerMask ground_lM;
    bool is_grounded;
 

    // Update is called once per frame
    void Update()
    {
        is_grounded = Physics.CheckSphere(ground_check.position,sphere_distance,ground_lM);
        if(is_grounded && velocity_for_y.y<0f)
        {
            velocity_for_y.y = -2f;
        
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move =transform.right * x + transform.forward * z;
        controler_player.Move(move*spped*Time.deltaTime);

        if(Input.GetButtonDown("Jump") && is_grounded)
        {
            velocity_for_y.y =  Mathf.Sqrt(jump_height*-2f*gravity);
        }
        velocity_for_y.y += gravity * Time.deltaTime;
        controler_player.Move(velocity_for_y * Time.deltaTime);
        
    }
}
