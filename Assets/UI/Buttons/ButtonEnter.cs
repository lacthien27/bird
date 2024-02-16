using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnter : ButtonBase
{
    
    protected override void OnClick()
    {
        this.gameCtrl.birdCtrl.gameObject.SetActive(true);
        this.gameCtrl.barrierSpawnerCtrl.gameObject.SetActive(true);
        transform.parent.gameObject.SetActive(false);//set button disable then when pressed
        GameReset.instance.PlayAgain();
    }
}
