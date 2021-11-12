using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torch_script : MonoBehaviour
{
   
    [Header("Torch")]
    [SerializeField]private GameObject torch_gb;
    [SerializeField]private bool is_on = false;
    [SerializeField]private AudioSource torch_sound;
    [SerializeField]private bool fail_safe = false;
    
    void Update()
    {
        if(Input.GetKey(KeyCode.T))
        {
            if(is_on == false && fail_safe == false)
            {
                fail_safe = true;
                torch_gb.SetActive(true);
                is_on = true;
                StartCoroutine(Fail_S_fn());

            }
            if(is_on == true && fail_safe == false)
            {
                fail_safe = true;
                torch_gb.SetActive(false);
                is_on = false;
                StartCoroutine(Fail_S_fn());
            }
            
        }
    }
    IEnumerator Fail_S_fn()
    {
        yield return new WaitForSeconds(0.25f);
        fail_safe = false;
    }
}
