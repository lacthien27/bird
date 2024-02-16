using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MountainFarMove : ObjectMove
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.speed =0.3f;
    }

}
