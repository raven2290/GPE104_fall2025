using UnityEngine;

public class Bullet : MonoBehaviour
{
    public DamageOnCollision damageOnCollisionComponent;
    public BulletMover bulletMoverComponent;

    public void awake()
    {
        // load components
        damageOnCollisionComponent = GetComponent<DamageOnCollision>();
        bulletMoverComponent = GetComponent<BulletMover>();
    }
}
