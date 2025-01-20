using spaceExplorer.Health;
using UnityEngine;

namespace spaceExplorer.Enemy
{
    public class Enemy : MonoBehaviour
    {
        private float maxHealth = 100f;
        private HealthSystem healthSystem;

        private void Awake()
        {
            healthSystem = GetComponent<HealthSystem>();
            healthSystem.Setup(maxHealth);
        }
    }
}

