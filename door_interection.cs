using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_interection : MonoBehaviour
{
  
    private bool open = false;
    private bool safe_d = false;

    [SerializeField]private GameObject open_text ;
    [SerializeField]private GameObject close_text ;
     


    public void door_work()
    {
        
        Animator ani = GetComponent<Animator>();
        if(open == false)
        {
            open_text.SetActive(true);
            close_text.SetActive(false);
        }
        if(open == true)
        {
            open_text.SetActive(false);
            close_text.SetActive(true);

        }
        if(Input.GetKey(KeyCode.E))
        {
            if(open == false && safe_d == false)
            {

                safe_d = true;
                ani.SetBool("open_door",true);
                open = true;
                StartCoroutine(Fail_S_fn());
            }
            if(open == true && safe_d == false)
            {
                safe_d = true;
                ani.SetBool("open_door",false);
                open = false;
                StartCoroutine(Fail_S_fn());
            }



        }
       
    }
    public void not_door_fn()
    {
        open_text.SetActive(false);
        close_text.SetActive(false);

    }
    
    IEnumerator Fail_S_fn()
    {
        yield return new WaitForSeconds(0.25f);
        safe_d = false;
    }

}
