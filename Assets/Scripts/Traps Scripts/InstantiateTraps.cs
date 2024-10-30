using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InstantiateTraps : MonoBehaviour
{
    public GameObject parent;
    public GameObject traps;
    public OneScriptToRuleThemAll gameData;

    private void Start()
    {
        InstantiateTrap();
    }

    public void InstantiateTrap()
    {
        for(int i = 0; i < gameData.TrapSpawnPoints.Count; i++)
        {
            Instantiate(traps, gameData.TrapSpawnPoints[i], Quaternion.identity, parent.transform);
        }
    }
}
