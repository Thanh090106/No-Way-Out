using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
     private float xAxis = 0;
    private  float yAxis = 0;
    float xAxisTurnRate = 360f;
    float yAxisTurnRate = 360f;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    void LateUpdate()
    {
       
        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0);
        Camera.main.transform.rotation = newRotation;
    }


    public void AddXAxisInput(float input)
    {
        xAxis -= input * xAxisTurnRate;
        xAxis = Mathf.Clamp(xAxis, -90f, 90f);
    }


    public void AddYAxisInput(float input)
    {
        yAxis += input * yAxisTurnRate;
    }
}
