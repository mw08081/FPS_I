using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    Transform mainCam;

    void Start()
    {
        mainCam = Camera.main.transform;
    }

    void Update()
    {
        float vert = Input.GetAxis("Vertical");
        float horz = Input.GetAxis("Horizontal");

        Vector3 dir = new Vector3(horz, 0, vert);

        transform.position += dir * 10 * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, mainCam.eulerAngles.y, 0);
    }
}
