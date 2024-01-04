using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ThienMonoBehaviour : MonoBehaviour
{
    protected virtual void OnEnable()
    {
        
    }
    protected virtual void Start(){;}

    protected  virtual void Awake() 
    {
        this.LoadComponents();
        
    }
     protected virtual void Reset()
    { 
        this.LoadComponents();
        this.ResetValue();
    }

    protected virtual void LoadComponents()
    {
    }

    protected  virtual void ResetValue()
    {
        //reserved for children
    }

  
}
