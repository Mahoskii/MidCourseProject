using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DeliveryPointScriptable : ScriptableObject
{
public List<Vector2> DeliveryPointsLocationList = new List<Vector2> { 
    new Vector2(4394, -116),
    new Vector2(914, 1816), 
    new Vector2(4738, 1135),
    new Vector2(7288, 4025), 
    new Vector2(-798, 4078), 
    new Vector2(-798, 4078) };
}
