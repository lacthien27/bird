using System.Collections;
using System.Collections.Generic;
using System.Resources;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class GetInput : thienMonoBehaviour
{

    [SerializeField] public  InputCtrl inputCtrl;

    public static GetInput instance;

    protected bool isDownButtonHeld = false;
    public int buttonValue;
    public float timer=0f;
    public float holdTime =0.02f;
   protected override void LoadComponents()
   {
    
    base.LoadComponents();
    this.GetKey();
    this.LoadInputCtrl();
   GetInput.instance = this;
   }

   protected virtual void LoadInputCtrl()
   {
    if(this.inputCtrl !=null) return;
        this.inputCtrl = GetComponentInParent<InputCtrl>(); 
        Debug.LogWarning(transform.name+"LoadinputCtrl",gameObject);
   }

     void Update() 
    {
        this.GetKey();
        
    }
    protected virtual void GetKey()
    {
        if(Input.GetButtonDown("Jump"))
        {   
            this.buttonValue=1;
            timer=0f;
        }
        if(this.buttonValue==1 && timer>=holdTime)
        {
            this.buttonValue=0;   
        }
        timer+=Time.deltaTime;
    }




   
}
