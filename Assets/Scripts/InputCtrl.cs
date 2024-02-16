using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCtrl : thienMonoBehaviour
{
    [SerializeField] public  GameCtrl gameCtrl;
    [SerializeField] public  GetInput  getInput;

    protected override void LoadComponents()
    {
        this.LoadGameCtrl();
        this.LoadGetInput();
    }

    protected virtual void  LoadGameCtrl()
    {

        if(this.gameCtrl !=null) return;
        this.gameCtrl = GameObject.FindObjectOfType<GameCtrl>(); 
        Debug.LogWarning(transform.name+"LoadGameCtrl",gameObject);
    }

    protected   virtual void LoadGetInput()
    {
        if(this.getInput !=null) return;
        this.getInput = GetComponentInChildren<GetInput>(); 
        Debug.LogWarning(transform.name+"LoadgetInput",gameObject);        
    }

}
