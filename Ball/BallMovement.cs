using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BallMovement : ThienMonoBehaviour
{
    [SerializeField] public BallCtrl ballCtrl;
    [SerializeField] public float speed = 0.1f;
    [SerializeField] public Vector2  velocity;




    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBallCtrl();

    }

    private  void FixedUpdate()
    {
        
        this.LoadMovement();
                this.Sync();    

    } 

    
    
    protected virtual void LoadBallCtrl()
    {
        if(this.ballCtrl!=null) return;
        this.ballCtrl =GetComponentInParent<BallCtrl>();
        Debug.LogWarning(transform.name+ ": LoadBallCtrl",gameObject);
    }

 
    protected virtual void LoadMovement()
    {
    if (ButtonPlayer.instance.isShotting == 0) return;

    if (ballCtrl.ballImpact.Impacted == 0)
    {
        transform.Translate(new Vector2(0, 1) * this.speed * Time.deltaTime);
    }
    else
    {
        transform.Translate(this.ballCtrl.ballImpact.reflectionVector * this.speed * Time.deltaTime);
  
    }
    }

    protected virtual void Sync()
    {   
        this.transform.parent.position= this.transform.position;
        this.ballCtrl.ballImpact.transform.position= this.transform.parent.position;
        
    }


  

   


  
   

}

