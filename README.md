# FPS_I
First FPS Game with 인생유니티교과서

// 22.03.28.~

MY Question  
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

  
  +++Link) https://github.com/mw08081/FPS_I/blob/main/Assets/Resource/Player/cs/PlayerInputController.cs
