using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTrapSpawn : MonoBehaviour
{
    public GameObject HighwayTrap, BikeLaneTrap, RedLightTrap;
    int whichTrapToSpawn = 0;

    //void Start()
    //{
    //    SpawnTrap();
    //}

    private void OnEnable()
    {
        SpawnTrap();
    }

    public void SpawnTrap()
    {
        whichTrapToSpawn = Random.Range(1, 4);
        TrapSpawning(whichTrapToSpawn);
    }

    public void TrapSpawning(int whichTrapToSpawn)
    {
        switch (whichTrapToSpawn)
        {
            case 1:

                if(!BikeLaneTrap.activeSelf && !RedLightTrap.activeSelf)
                {
                    HighwayTrap.SetActive(true);
                }

                break;

            case 2:

                if(!HighwayTrap.activeSelf && !RedLightTrap.activeSelf)
                {
                    BikeLaneTrap.SetActive(true);
                }
                
                break;

            case 3:

                if(!HighwayTrap.activeSelf && !BikeLaneTrap.activeSelf)
                {
                    RedLightTrap.SetActive(true);
                }
                
                break;
        }

    }
}
