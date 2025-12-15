using UnityEngine;

public class EnemyFormationShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootChance = 0.02f; // 2% chance each frame to shoot

    void Update()
    {
        if (Random.value < shootChance)
        {
            Transform randomChild = transform.GetChild(Random.Range(0, transform.childCount));
            Instantiate(bulletPrefab, randomChild.position, Quaternion.identity);
        }
    }
}
