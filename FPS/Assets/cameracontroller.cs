using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public float MouseSensitivity = 100f;
    public Transform player;
    float xRotation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") *MouseSensitivity *Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity *Time.deltaTime;


        //mouse X and y are predefined in unity to rotate in camera view

        xRotation -= mouseY;
        //vertical rotation of the camera based on the mouse movement along the Y-axis.
        xRotation = Mathf.Clamp(xRotation, -45f, 45f);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        player.Rotate(Vector3.up * mouseX);







    }
}
