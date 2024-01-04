using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Brick",menuName = "SO/Brick")]
public class BrickSO : ScriptableObject
{
    public string  BrickName = "Brick";
    public int hpMax = 0;
    public  List<DropRate> dropList;
}
