using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetType() == typeof(BoxCollider))
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Enemy hit");
                var enemyStats = other.gameObject.GetComponent<EnemyStats>();
                enemyStats.TakeDamage(damage);
            }

            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Player hit");
                GlobalStorage.Instance.DecreasePlayerHealth(damage);
            }
        }
    }
}
