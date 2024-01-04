using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonEnter : ButtonBase
{
    public override void OnClick()
    {
        GameCtrl.instance.playerCtrl.playerMovement.gameObject.SetActive(true);
        this.transform.parent.gameObject.SetActive(false);        
    }
}
