using UnityEngine;

public class DestroySelfOnCollision : MonoBehaviour
{
    public void OnCollisionenter(Collision collision)
    {
        Destroy(gameObject);
    }
}
