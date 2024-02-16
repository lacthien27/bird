using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class BarrierFly : thienMonoBehaviour

{

    [SerializeField] public float speed = 0.7f;
    protected override void LoadComponents()
    {
        base.LoadComponents();
       // this.move();
    }


     void Update() 
    {
        this.move();
    }

   




    protected virtual  void move()
    {
        transform.parent.Translate(Vector3.left*this.speed*Time.deltaTime);

    }




}
