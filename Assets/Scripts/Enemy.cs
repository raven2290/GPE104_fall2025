using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public Health health;
    public Shooter shooter;
    public abstract void Move(Vector3 moveVector);
    public abstract void Rotate(float angle);

    protected virtual void Start()
    {
        //load the health component
        health = GetComponent<Health>();
        // verify the health component
        if (health == null)
            Debug.LogWarning(gameObject.name + "does not have a health component");

        // load the shooter component
        shooter = GetComponent<Shooter>();

        // TODO: verify the shooter component

    }
}
