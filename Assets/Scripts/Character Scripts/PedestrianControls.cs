
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianControls : ICharacter
{
    public Animator animator;
    public Rigidbody2D rb;
    float boopForce = 1500f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        MovementAtUniqueSpeed(225000, rb, animator, "pedestrianSpeed");
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TrapInteraction(collision, rb, boopForce, "BikeLaneTrap", "HighwayTrap", "RedLightTrap");
    }

}
