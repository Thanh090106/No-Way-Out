using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera2 : MonoBehaviour
{
    CameraMovement firstPersonCamera;
    
    
    // Start is called before the first frame update
    void Start()
    {
        firstPersonCamera = GetComponent<CameraMovement>();
        
    }


    // Update is called once per frame
    void Update()
    {
        HandleCameraInput();
        
    }


    void HandleCameraInput()
    {
        firstPersonCamera.AddXAxisInput(Input.GetAxis("Mouse Y") * Time.deltaTime);
        firstPersonCamera.AddYAxisInput(Input.GetAxis("Mouse X") * Time.deltaTime);
    }


    
}
