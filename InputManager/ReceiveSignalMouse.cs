using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEditorInternal;

public class ReceiveSignalMouse : ThienMonoBehaviour
{
    public static ReceiveSignalMouse instance;
    public Vector3 mousePos = new  Vector3(0,0,0);
    public  int pressedMouse  = 0;
    public  float timeStart =0f;
    public  float timeLimit =0.02f;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        ReceiveSignalMouse.instance =this;
    }

     private void Update() 
    {
        this.LoadSignalMousePos();
        this.LoadSignalMousePress();
    
    }
    protected virtual void LoadSignalMousePos()
    {
        this.mousePos = Input.mousePosition;
        
    }

    protected virtual void LoadSignalMousePress()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.pressedMouse=1;
            this.timeStart=Time.time;
            if(this.timeStart>=this.timeLimit)
            {
                this.pressedMouse=0;
                timeStart=0;
            }
        }
    }
}
