using System.Linq.Expressions;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Data (variables)
    // Current health
    private float currentHealth;
    [SerializeField] private float maxHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //stat with max health
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float damage)
    {
        currentHealth = currentHealth - damage; // currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    public void Heal(float healAmaount)
    {
        currentHealth = currentHealth + healAmaount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth; //cant go over max health
        }
    }

    public void Die()
    {
        //TODO: Get the death component
        Death deathComponent = GetComponent<Death>();
        Debug.Log("hit");

        //TODO: tell the death component to die
        if (deathComponent != null)
        {
            deathComponent.Die();
            // if death
        }
        else
        {
            Debug.LogWarning("warning: " + gameObject.name + " has no death component!");
        }
    }

}
