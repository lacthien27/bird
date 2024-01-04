using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCtrl : ThienMonoBehaviour
{
    [SerializeField] public Rigidbody2D rb2D;
   protected override void  LoadComponents()
   {
        base.LoadComponents();
        this.LoadRb2D();
   }


   protected virtual void LoadRb2D()
   {
    if(this.rb2D !=null) return;
    this.rb2D= GetComponent<Rigidbody2D>();
    this.rb2D.isKinematic = true;

    Debug.LogWarning(transform.name +": LoadRb2d",gameObject);
   }
}
