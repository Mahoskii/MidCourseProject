using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter
{
    void MovementAtUniqueSpeed(float Speed);
    void OvercomeTrap(Vector2 boop);
}
