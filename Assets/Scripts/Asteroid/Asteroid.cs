using spaceExplorer.DamageSystem;
using spaceExplorer.Health;
using UnityEngine;

namespace spaceExplorer.Asteroid
{
    public class Asteroid : MonoBehaviour, IDamageSource
    {
        
        private HealthSystem healthSystem;
        private DamageDealer damageDealer;
        private readonly float damage = 10f;
        private readonly float maxHealth = 100f;

        private void Awake()
        {
            damageDealer = GetComponent<DamageDealer>();
            healthSystem = GetComponent<HealthSystem>();
            healthSystem.Setup(maxHealth);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Vulnerable target = collision.GetComponent<Vulnerable>();
            if (target)
            {
                damageDealer.DealDamage(target);
            }
        }
        float IDamageSource.GetDamage() => damage;
    }
}

