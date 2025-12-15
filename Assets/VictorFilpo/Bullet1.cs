using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosionPrefab; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Instantiate(explosionPrefab, collision.transform.position, Quaternion.identity);

            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
    }
}
