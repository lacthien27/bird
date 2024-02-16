using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using System;
using System.Runtime.CompilerServices;
using UnityEditor;


[RequireComponent(typeof(SphereCollider))]
[RequireComponent(typeof(Rigidbody))]
public class BirdImpact : thienMonoBehaviour
{
    
    [SerializeField] public BirdCtrl birdCtrl;
    [SerializeField] public SphereCollider sphereCollider;
    [SerializeField] public Rigidbody _rigidbody; 

    [SerializeField] public int impact =0;
    [SerializeField] public float birdImpactPoint=0;
    [SerializeField] public float birdImpactPointBest=0;


   


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBirdCtrl();
        this.LoadCollider();
        this.LoadRigidbody();


    }

    protected virtual void LoadBirdCtrl()
    {
         if(this.birdCtrl !=null) return;
        this.birdCtrl = GetComponentInParent<BirdCtrl>();
        Debug.LogWarning(transform.name+"LoadBirdCtrl",gameObject);
    }

     public virtual void LoadCollider()
    {
        if (this.sphereCollider != null) return;
        this.sphereCollider = GetComponent<SphereCollider>();
        this.sphereCollider.isTrigger = true;
        Debug.Log(transform.name + ": LoadCollider", gameObject);
    }

    public virtual void LoadRigidbody()
    {
        if (this._rigidbody != null) return;
        this._rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = true;
        Debug.Log(transform.name + ": LoadRigibody", gameObject);
    }

    protected virtual void OnTriggerEnter(Collider  other)
    {
        if(other.name=="TransparentImpact")
        {
            this.birdImpactPoint ++;

            if(this.birdImpactPoint>=this.birdImpactPointBest)
            {
                this.birdImpactPointBest++;
            }
            return;
        }
        this.birdCtrl.gameCtrl.buttonBase.transform.parent.gameObject.SetActive(true);    // display again buttonBase    
        this.impact=1;   // announce bird died
        this.CreateImpactFX(other);// effect
    }
    protected virtual void CreateImpactFX(Collider other)
    {
        string fxName =this.GetImpactFX();
        Transform fxImpact = FXSpawner.instance.Spawn(fxName,transform.parent.position,transform.parent.rotation );
        fxImpact.gameObject.SetActive(true);

    }

    protected virtual string GetImpactFX()
    {

        return FXSpawner.Smoke_1;
        
    }
}
