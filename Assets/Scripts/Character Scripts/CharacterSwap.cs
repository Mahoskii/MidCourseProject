using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwap : MonoBehaviour
{
    public GameObject car, bike, pedestrian;
    int whichActive = 1;

    // Start is called before the first frame update
    void Start()
    {
        car.SetActive(true);
        bike.SetActive(false);
        pedestrian.SetActive(false);

    }

    private void Update()
    {
        CharacterSwapping();
    }

    public void CharacterSwapping()
    {
        if (Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.Space))
        
            switch (whichActive)
            {
                case 1:
                    whichActive = 2;
                    car.SetActive(false);
                    bike.SetActive(true);
                    pedestrian.SetActive(false);
                    bike.transform.position = car.transform.position;
                    break;

                case 2:
                    whichActive = 3;
                    car.SetActive(false);
                    bike.SetActive(false);
                    pedestrian.SetActive(true);
                    pedestrian.transform.position = bike.transform.position;
                    break;

                case 3:
                    whichActive = 1;
                    car.SetActive(true);
                    bike.SetActive(false);
                    pedestrian.SetActive(false);
                    car.transform.position = pedestrian.transform.position;
                    break;
            }

    }
}
