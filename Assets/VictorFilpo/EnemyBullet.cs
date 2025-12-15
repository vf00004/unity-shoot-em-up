using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 5f;
    public GameObject explosionPrefab;
    void Update()
    {
        transform.Translate(Vector2.down * (this.speed * Time.deltaTime));
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (explosionPrefab != null)
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}