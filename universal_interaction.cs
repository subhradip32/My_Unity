using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class universal_interaction : MonoBehaviour
{
  #region variables
  public float dist_target;
  private float distance; 
  private RaycastHit hit;

       
  #endregion

    void Update() 
    {
        if(Physics.Raycast(transform.position,transform.forward,out hit))
        {
            distance = hit.distance;
        }

        dist_target = distance;
        Debug.Log(distance);
        if(distance <= 3f)
        {
            Debug.Log("heeehaaa---------------------------");
        }


    }




}
