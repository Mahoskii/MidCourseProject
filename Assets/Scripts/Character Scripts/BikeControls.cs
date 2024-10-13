using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeControls : MonoBehaviour, ICharacter
{
    public Rigidbody2D rb;
    float boopForce = 20f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        MovementAtUniqueSpeed(2000);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("RedLightTrap") || collision.gameObject.CompareTag("HighwayTrap"))
        {
            //find in what direction to boop the player
            Vector2 boopDirection = (transform.position - collision.transform.position).normalized;
            //boop the player in the correct direction with the wanted force
            Vector2 boop = boopDirection * boopForce;
            OvercomeTrap(boop);
        }
        else if(collision.gameObject.CompareTag("BikeLaneTrap"))
        {
            collision.gameObject.SetActive(false);
        }
    }
    public void MovementAtUniqueSpeed(float Speed)
    {
        var dir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.drag = 15;
        rb.AddForce(Speed * Time.fixedDeltaTime * dir);
    }

    public void OvercomeTrap(Vector2 boop)
    {
        rb.AddForce(boop, ForceMode2D.Impulse);
    }
}
