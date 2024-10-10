using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarControls : MonoBehaviour, ICharacter
{
    public Rigidbody2D rb;
    float boopForce = 25f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        MovementAtUniqueSpeed(3000);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("RedLightTrap") || collision.gameObject.CompareTag("BikeLaneTrap"))
        {
            //find in what direction to boop the player
            Vector2 boopDirection = (transform.position - collision.transform.position).normalized;
            //boop the player in the correct direction with the wanted force
            Vector2 boop = boopDirection * boopForce;
            OvercomeTrap(boop);
        }
        else
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
