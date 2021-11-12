using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_look : MonoBehaviour
{
    [SerializeField] private float look_sensivity = 100f;
    float xrotation = 0f;
    [SerializeField]private Transform player_body;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;


    }

    // Update is called once per frame
    void Update()
    {
       float mousex = Input.GetAxis("Mouse X") * look_sensivity * Time.deltaTime;
       float mousey = Input.GetAxis("Mouse Y") * look_sensivity * Time.deltaTime;

       xrotation -= mousey;
       xrotation = Mathf.Clamp(xrotation,-90f,90f);

        transform.localRotation = Quaternion.Euler(xrotation,0f,0f);
        player_body.Rotate(Vector3.up * mousex);

    }
}
