using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor;
using UnityEngine;

public class Spawner : ThienMonoBehaviour
{
   [SerializeField] protected List<Transform> prefabs;

   [SerializeField] protected List<Transform> poolObjs;
   [SerializeField] protected Transform holder;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPrefabs();
        this.LoadHolder();
    }


    protected virtual  void LoadHolder()
    {
        if(this.holder !=null)
        {
            return;
        }
        holder = transform.Find("Holder");
        Debug.Log(transform.name+"loadHolder , find and attach connect it",gameObject);
    }

    protected virtual void LoadPrefabs()
    {
        if(this.prefabs.Count>0) return;
        Transform prefabsObj = transform.Find("Prefabs");
        foreach( Transform prefab in prefabsObj)
        {
            this.prefabs.Add(prefab);
        }

        this.HidePrefabs();
        Debug.Log(transform.name +"reset lại LoadPreFabs",gameObject  );
    }

    protected virtual void HidePrefabs()
    {
        foreach( Transform prefab in prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }

    public virtual Transform Spawn(string prefabName ,Vector3 spawnPos, Quaternion  rotation)
    {   
        Transform prefab = this.GetPrefabByName(prefabName);   
        if(prefab ==null)   
        {
            Debug.Log("Prefab not found:"+prefabName);
            return null;
        }
        return this.Spawn(prefab,spawnPos,rotation);
    }

        
     public virtual Transform Spawn(Transform prefab ,Vector3 spawnPos, Quaternion  rotation)
    {          
        // gọi từ hàm  pool lên tái sử dụng lại
        Transform newPrefab =this.GetObjFromPool(prefab);
        newPrefab.SetPositionAndRotation(spawnPos,rotation);

        newPrefab.parent =this.holder;  // holder dùng để chứa đạn bắn
        return newPrefab;
    }

    public virtual Transform GetPrefabByName(string prefabName)
    {
        foreach(Transform prefab in this.prefabs)
        {
            if(prefab.name == prefabName) return prefab;
        }
        return null;
    }

    protected virtual Transform GetObjFromPool(Transform prefab)
    {
        foreach( Transform poolObj in this.poolObjs)
        {
            if(poolObj.name == prefab.name)
            {
             this.poolObjs.Remove(poolObj);
             return poolObj;

            }
        }
    
    Transform newPrefab = Instantiate(prefab);
    newPrefab.name = prefab.name;
    return newPrefab;
    }

    
   public virtual void Despawn(Transform obj)   
    {
        this.poolObjs.Add(obj);  //  obj thêm nó vào hàng đợi 
        obj.gameObject.SetActive(false); 
    }


}
