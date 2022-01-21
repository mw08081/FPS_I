using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    Transform mainCam;
    
    
    [SerializeField] float rotSpeed;

    Vector3 look;
    float mouseX;
    float mx;

    void Start()
    {
        mainCam = Camera.main.transform;
    }

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mx += mouseX * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, mx, 0);
         


        //float vert = Input.GetAxis("Vertical");
        //float horz = Input.GetAxis("Horizontal");

        //Vector3 dir = new Vector3(horz, 0, vert);

        //transform.position += dir * 10 * Time.deltaTime;
        //transform.eulerAngles = new Vector3(0, mainCam.eulerAngles.y, 0);
    }
}
