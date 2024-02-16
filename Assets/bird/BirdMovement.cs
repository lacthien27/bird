using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;

using Unity.VisualScripting;
using UnityEditor.U2D.Path;
using UnityEditor.XR;
using UnityEngine;

public class BirdMovement : thienMonoBehaviour
{

   
    [SerializeField] public  float speed= 10f;
    [SerializeField] public BirdCtrl birdCtrl;
    [SerializeField ]  public float gravityScale =18f;
    [SerializeField] public    Vector3 velocity;


   protected override void LoadComponents()
   {
    base.LoadComponents();
    this.LoadBirdCtrl();
    
   }
    void FixedUpdate()
   {
    this.LoadBirdMovement();
   }
    protected virtual void LoadBirdMovement()
    {
        if(birdCtrl.gameCtrl.inputCtrl.getInput.buttonValue>0)
        {          
            velocity.y=0f;
            velocity.y+=  this.speed;
       }
        this.LoadBirdPointFall();
        velocity.y -= this.gravityScale*Time.fixedDeltaTime;

        this.transform.parent.position += velocity*Time.fixedDeltaTime; 
    }   

    protected virtual void LoadBirdPointFall()
    {
        if(this.transform.parent.position.y >=6)
        {
            this.transform.parent.position = new Vector3(0,-5,0);
            

        }

        if(this.transform.parent.position.y <=-6)
        {
            this.transform.parent.position = new Vector3(0,5,0);
        }
    }


    protected virtual void LoadBirdCtrl()
    {
        if(this.birdCtrl !=null) return;
        this.birdCtrl = GetComponentInParent<BirdCtrl>();
        Debug.LogWarning(transform.name+"LoadBirdCtrl",gameObject);
    }

    
    

}
