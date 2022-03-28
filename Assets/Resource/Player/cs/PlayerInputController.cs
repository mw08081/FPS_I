using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    //Character
    [SerializeField] CharacterController cc;
    float gravitiy = -20f;
    [SerializeField] float yVelocity = 0;

    //rotate
    [SerializeField] float rotSpeed;
    float mouseX;
    float mx;

    //move
    [SerializeField] float moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        RotatingPlayer();
        MovingPlayer();
    }

    void RotatingPlayer()
    {
        mouseX = Input.GetAxis("Mouse X");
        mx += mouseX * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, mx, 0);
    }

    void MovingPlayer()
    {
        float vert = Input.GetAxis("Vertical");
        float horz = Input.GetAxis("Horizontal");

        Vector3 dir = new Vector3(horz, 0, vert);                           //CodeD
        //Vector3 dir = new Vector3(horz, -9.87f, vert);                    //CodeE
        dir = dir.normalized;
        dir = Camera.main.transform.TransformDirection(dir);

        //<summary>
        // 
        //  #1. CodeA, Rigidbody, CapsuleCollider
        //  #2. CodeB, CharacterController
        //
        //  When you Have this code, RigidBody and CapSuleCollider, Player just go up, and fall Down
        //  But now Why Player just go up and Fall Down??
        //
        //  I think #1 is not calculate gravitiyForce RealTimely.
        //  But #2 calculate gravityForce RealTimely for everyFrame(CodeB)
        //<summary/>
        //  |
        //  |
        //  |
        //  |
        //transform.position += dir * moveSpeed * Time.deltaTime;           //CodeA

        //<summary>
        // 
        //  #1. Code C - yVelocity += gravitiy * Time.deltaTime;    (wellDone!!)
        //  #2. Code D - yVelocity = -9.87f;                        (wellDone!!)
        //  #3. Code E(Upgrade Code D)                              (It doesnt worked!!)
        //
        //  yVelocity += gravitiy * Time.deltaTime;
        //  this code make yVelocitiy down unlimitly, so why not just set yVelocity < 0 ??
        //  and why set Gravitiy Scale = -20f;
        //  
        //  #2 is nice work!!
        //  
        //  #3. Change dirVector with yVelocity into Camera Standard Vector using TransformDirction(LINE 46)
        //  
        //<summary/>

        //<CodeB>
        //yVelocity += gravitiy * Time.deltaTime;                             //CodeC
        yVelocity = -9.87f;                                                   //CodeD
        dir.y = yVelocity;

        //<summary>
        // 
        //  #1. Code F - cc.Move(dir * moveSpeed * Time.deltaTime);                 (wellDone!!)
        //  #2. Code G - transform.position += dir * moveSpeed * Time.deltaTime     (It doesnt worked)
        //
        //  I dont know What is Different in CodeF, CodeG  
        //
        //<summary/>
        cc.Move(dir * moveSpeed * Time.deltaTime);              
        //<CodeB/>
    }
}
