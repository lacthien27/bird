using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonPlayer : ButtonBase
{
    [SerializeField] public static ButtonPlayer instance;
    protected override void Start()
    {
        ButtonPlayer.instance= this;

        base.Start();
        this.LoadColor();


    }
    protected virtual void LoadColor()
    {
    image.color= new Color(0.0f, 0.0f, 0.0f, 0.0f);
    }
   
    public override void OnClick()
    {
        this.isShotting =1;
    }


    
void FixedUpdate() 
{
   transform.parent.position = GameCtrl.instance.playerCtrl.transform.position;    
}

}

