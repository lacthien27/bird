using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextShowPointsBest : TextBase
{   
    [SerializeField]public int pointBest =0;
    protected virtual void FixedUpdate()
    {
        this.UpdatePointsBest();
    }
    protected virtual void UpdatePointsBest()
    {
        this.pointBest=(int)GameCtrl.instance.birdCtrl.birdImpact.birdImpactPointBest/2;
        this.text.SetText("Best:"+pointBest.ToString());
    }
}
