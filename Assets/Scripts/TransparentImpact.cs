using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentImpact : thienMonoBehaviour
{
    [SerializeField] public int birdImpactPoint=0;
    
    [SerializeField] public CapsuleCollider capcollider;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCollider();
    }   

   

    protected virtual void LoadCollider()
    {
        if(this.capcollider!=null) return;
        this.capcollider=GetComponent<CapsuleCollider>();
        capcollider.isTrigger=true;
        this.capcollider.height=6;
        this.capcollider.radius=0.4f;
        Debug.LogWarning(transform.name+":LoadCollider",gameObject);
    }

    // protected virtual void OnTriggerEnter(Collider  other)
    // {
    //     string colliderNameOther = other.gameObject.name;

    //     if(colliderNameOther=="BirdImpact")
    //     {
    //         Debug.LogWarning("f");
    //     }
    // }

}
