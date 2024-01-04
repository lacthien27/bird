using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ItemCtrl : ThienMonoBehaviour
{
    [SerializeField] public ItemDespawn itemDespawn;
    [SerializeField] public CircleCollider2D circleCollider2D;



    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItemDespawn();
        this.LoadCollider2D();
    }

    

     protected virtual void LoadItemDespawn()
    {
        if(this.itemDespawn !=null) return;
        this.itemDespawn = GetComponentInChildren<ItemDespawn>();
        Debug.LogWarning(transform.name+" : LoadItemDespawn",gameObject);
    }

    
   

      protected virtual void LoadCollider2D()
    {
        if(this.circleCollider2D !=null) return;
        this.circleCollider2D =GetComponent<CircleCollider2D>();
        Debug.LogWarning(transform.name+" :LoadCircleCollider2D");
    }
   
}
