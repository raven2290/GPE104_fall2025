using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
    public bool selfDestructOnCollision = false;
    public float damageDone = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collisionData)
    {
        // get the pawn on the other object
        Health otherObjectHealth = collisionData.gameObject.GetComponent<Health>();

        // if that pawn exists
        if (otherObjectHealth != null)
        {
            
            otherObjectHealth.TakeDamage(damageDone);
            ;
        }
        // see if we should destroy ourself
        if (selfDestructOnCollision)
        {
            Destroy(gameObject);
        }
    }
}
