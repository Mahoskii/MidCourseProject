using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomTrap : MonoBehaviour
{
    public GameObject HighwayTrap, BikeLaneTrap, RedLightTrap;
    int whichTrapToSpawn = 0;

    void Start()
    {
        whichTrapToSpawn = Random.Range(1, 4);
        TrapSpawning(whichTrapToSpawn);
    }

    public void TrapSpawning(int whichTrapToSpawn)
    {
            switch (whichTrapToSpawn)
            {
                case 1:
                    HighwayTrap.SetActive(true);
                    break;

                case 2:
                    BikeLaneTrap.SetActive(true);
                    break;

                case 3:
                    RedLightTrap.SetActive(true);
                    break;
            }

    }
}
