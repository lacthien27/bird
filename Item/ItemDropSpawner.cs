using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropSpawner : Spawner
{
    public static ItemDropSpawner instance;

   // [SerializeField] public ItemCtrl itemCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
       // this.LoadItemCtrl();
    }

    // protected virtual void LoadItemCtrl()
    // {
    //     if(this.itemCtrl!=null) return;
    //     this.itemCtrl =GameObject.FindObjectOfType<ItemCtrl>();
    //     Debug.LogWarning(transform.name+" : LoadItemCtrl",gameObject);
    // }


    

    protected override void Awake()
    {
        base.Awake();
        if(ItemDropSpawner.instance !=null) Debug.LogWarning("only 1 dropManager");
        ItemDropSpawner.instance =this;
    }

    public virtual void Drop(List<DropRate> dropList,Vector3 pos, Quaternion rot)
    {

         ItemCode itemCode = dropList[0].itemSO.itemCode;
        Transform itemDrop = this.Spawn(itemCode.ToString(), pos, rot);
        if (itemDrop == null) return;
        itemDrop.gameObject.SetActive(true);

       

    }
}
