using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollow : MonoBehaviour {
    public GameObject Player;

    private Vector3 offest;
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    public float yaw = 0.0f;
    public float pitch = 0.0f;


    private void Start()
    {
        offest = transform.position - Player.transform.position;
    }

    private void LateUpdate()
    {
       
        transform.position = Player.transform.position + offest;

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);  
    }

}
