using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : ThienMonoBehaviour
{   
    [SerializeField] public float speed =1f;
    [SerializeField] public Vector3 worldPos;
 void FixedUpdate() 
    {
        this.LoadMovement();
    }    
   

    public virtual void LoadMovement()
    {
        
        this.worldPos=Camera.main.ScreenToWorldPoint(ReceiveSignalMouse.instance.mousePos);
        this.worldPos.z=-1f;
        this.worldPos.y=-4.77f;
        Vector3 newPos= Vector3.Lerp(transform.position,worldPos,this.speed);
        transform.parent.position=newPos;

        if(this.worldPos.x>7.6f||this.worldPos.x<-7.6f)
        {
            if(this.worldPos.x>=5.15f)
            {
                transform.parent.position=new Vector3(7.59f,-4.77f,-1f);
            } 
            if(this.worldPos.x<=-5.15f)
            {
                transform.parent.position=new Vector3(-7.59f,-4.77f,-1f);
            }
        }


        
    }
}
