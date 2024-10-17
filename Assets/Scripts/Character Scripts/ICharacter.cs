using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICharacter : MonoBehaviour
{
    bool facingRight = true;
    public void MovementAtUniqueSpeed(float Speed, Rigidbody2D rb, Animator animator, string animationName)
    {
        var dir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.drag = 15;
        rb.AddForce(Speed * Time.fixedDeltaTime * dir);

        if(dir.x > 0 && !facingRight)
        {
            SpriteFlip();
        } else if(dir.x < 0 && facingRight)
        {
            SpriteFlip();
        }
        animator.SetFloat(animationName, Mathf.Abs(dir.x));
    }
    public void TrapInteraction(Collision2D collision, Rigidbody2D rb, float boopForce, string TrapFail1, string TrapFail2, string TrapPass)
    {
        if (collision.gameObject.CompareTag(TrapFail1) || collision.gameObject.CompareTag(TrapFail2))
        {
            //find in what direction to boop the player
            Vector2 boopDirection = (transform.position - collision.transform.position).normalized;
            //boop the player in the correct direction with the wanted force
            Vector2 boop = boopDirection * boopForce;
            rb.AddForce(boop, ForceMode2D.Impulse);
        }
        else if (collision.gameObject.CompareTag(TrapPass))
        {
            collision.gameObject.SetActive(false);
        }
        
    }

    private void SpriteFlip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;
        facingRight = !facingRight;
    }


}
