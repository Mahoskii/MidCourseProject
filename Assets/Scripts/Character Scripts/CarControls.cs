using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControls : MonoBehaviour, ICharacter
{
    public void MovementAtUniqueSpeed(float Speed)
    {
        var dir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.Translate(dir * Speed * Time.deltaTime);
    }

    public void OvercomeTrap()
    {
        throw new System.NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        MovementAtUniqueSpeed(5);
    }
}
