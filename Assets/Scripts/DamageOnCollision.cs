using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void
    //or        OnTriggerEnter2D(Collider2D collision)
    OnCollisionEnter2D(Collision2D collisionData)
    {
        // get the pawn on the other object
        //Pawn otherPawn = collision.gameObject.GetComponent<Pawn>();
        Pawn otherPawn = collisionData.gameObject.GetComponent<Pawn>();

        // if that pawn exists
        if (otherPawn != null)
        {
            otherPawn.health.TakeDamage(1);
        }
    }
}
