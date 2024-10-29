using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class RoundScriptableObject : ScriptableObject
{
    public Vector2 DeliveryPointLocation;
    public float RoundTime;
    public float TimeEnded = 0;
    public List<Vector2> TrapsSpawnLocations;
}
