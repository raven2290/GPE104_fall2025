using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Pawn target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            target.health.TakeDamage(1);
            //Debug.Log("OW");
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            target.health.Heal(1);
            //Debug.Log("YAY");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            target.health.Die();
            //Debug.Log("I DIED");
        }
        
    }
}
