using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Versioning;
using Unity.IO.LowLevel.Unsafe;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Analytics;

public class Spawner : thienMonoBehaviour
{
    [SerializeField] public List<Transform> prefabs;  

    [SerializeField] protected List<Transform> poolObjs;    

        
    
     [SerializeField] protected Transform  holder;
    [SerializeField] public GameCtrl gameCtrl;
    


    protected override  void LoadComponents()
    {
        base.LoadComponents();
        this.LoadGameCtrl();
        this.LoadPrefabs();
        this.LoadHolder();

    }
     protected virtual void LoadHolder() //  hàm giữ đạn bắn ,
    {   
        if(this.holder !=null) return;
        holder = transform.Find("Holder"); 
        Debug.Log(transform.name+"loadHolder , find and attach connect it",gameObject);
    }

    protected virtual void LoadPrefabs()
    {
        if(this.prefabs.Count >0) return;
        Transform prefabsObj = transform.Find("Prefabs");
        foreach(Transform prefab  in  prefabsObj)     
        {
            this.prefabs.Add(prefab);
        }
        this.HidePrefabs();  
        Debug.Log(transform.name +"reset lại LoadPreFabs",gameObject  );
    }


    protected virtual  void   HidePrefabs()  
    {
        foreach(Transform prefab in prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }


    public virtual Transform  Spawn(string prefabName,Vector3 spawnPos,Quaternion roration)
    {
        Transform prefab = this.GetPrefabByName(prefabName);
        if(prefab==null)
        {
             Debug.Log("Prefab not found:"+prefabName);
            return null;
        }
        return this.Spawn(prefab, spawnPos,roration);
    }

    public virtual Transform Spawn (Transform prefab,Vector3 spawnPos,Quaternion rotation)
    {
        Transform newPrefab =this.GetObjectFromPool(prefab); // method take obj when obj died and  added to Pools
        newPrefab.SetPositionAndRotation(spawnPos,rotation);  // if without it , gameobject do not spawn Exactly postion and rotation;

        newPrefab.parent =this.holder;  // holder dùng để chứa đạn bắn
       return newPrefab;
        
    }


    protected virtual void LoadGameCtrl()
    {
        if(this.gameCtrl !=null) return;
        this.gameCtrl = GameObject.FindObjectOfType<GameCtrl>(); 
        Debug.LogWarning(transform.name+"LoadGameCtrl",gameObject);  

    }

    public virtual  Transform  GetPrefabByName(string prefabName)
    {
        foreach( Transform prefab in this.prefabs)
            {
                if(prefab.name == prefabName) return prefab;
            }
        return null;
    }
    protected virtual Transform GetObjectFromPool(Transform prefab)
    {
        foreach( Transform poolObj in this.poolObjs)
        {
            if(prefab.name == poolObj.name)
            {
                this.poolObjs.Remove(poolObj);
                return poolObj;
            }
            
        } 
        Transform newPrefab =  Instantiate(prefab);
        newPrefab.name = prefab.name;
        return newPrefab;

    }

    public virtual void Despawn( Transform obj)
    {
        this.poolObjs.Add(obj);
        obj.gameObject.SetActive(false);
    }


    public  virtual  Transform RandomPrefab()
    {
        int rand = Random.Range(0,this.prefabs.Count);
        return this.prefabs[rand];
    }


    public virtual Transform GetPrefabFromLoop() // get obj
    {
        
        foreach(Transform i in this.prefabs )
        {
            return i;
        }

        return null;
    }







        
    


}

