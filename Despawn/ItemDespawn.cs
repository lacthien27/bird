using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDespawn : Despawn
{

     protected override bool   CanDespawn()
    {
        if(GameCtrl.instance.playerCtrl.playerImpact.gotItem) return true;
        return false;
    }
}

