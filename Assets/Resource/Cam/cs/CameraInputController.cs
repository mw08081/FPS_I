using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInputController : MonoBehaviour
{
    Vector3 dir;

    float dirX;
    float dirY;

    [SerializeField] float rotSpeed;

    void Start()
    {
        
    }
    
    void Update()
    {
        dirX += Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime;
        dirY += Input.GetAxis("Mouse Y") * rotSpeed * Time.deltaTime;

        dir = new Vector3(-dirY, dirX, 0);
        dirY = Mathf.Clamp(dirY, -90f, 90f);

        transform.eulerAngles = dir;
    }
}
