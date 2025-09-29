using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Bullet bulletToShoot;
    public Transform firePoint;
    public void Shoot()
    {
        Shoot(bulletToShoot);
    }
        

    public void Shoot( Bullet bulletToShoot )
    {
        // Instantiate a bullet at the shooter's position and rotation
        Bullet theBullet = Instantiate<Bullet>(bulletToShoot, firePoint.position, firePoint.rotation);
    }

}
