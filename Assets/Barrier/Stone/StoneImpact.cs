using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SphereCollider))]
[RequireComponent(typeof(Rigidbody))]

public class StoneImpact : thienMonoBehaviour
{
     [SerializeField] public SphereCollider sphereCollider;
    [SerializeField] protected Rigidbody _rigidbody;

    [SerializeField] protected  StoneCtrl stoneCtrl;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRigid();
        this.LoadSphere();
    }


    protected virtual void LoadRigid()
    {
        if (this._rigidbody != null) return;
        this._rigidbody = GetComponent<Rigidbody>();
        this._rigidbody.isKinematic = true;
        Debug.Log(transform.name + ": LoadRigibody", gameObject);
    }

    protected virtual void LoadSphere()
    {
       if (this.sphereCollider != null) return;
        this.sphereCollider = GetComponent<SphereCollider>();
        this.sphereCollider.isTrigger = true;
        this.sphereCollider.radius = 0.4f;
        Debug.Log(transform.name + ": LoadCollider", gameObject); 
    }

  
}
