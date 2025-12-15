using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 3;
    public GameObject[] lifeIcons;

    private void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemyFireball_0") || collision.CompareTag("Enemy"))
        {
            TakeDamage();
            Destroy(collision.gameObject); 
        }
    }

    private void TakeDamage()
    {
        lives--;

        if (this.lives >= 0)
        {
            lifeIcons[lives].SetActive(false);
        }

        if (lives <= 0)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<PlayerController>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;

            Invoke(nameof(this.ResetGame), 2f);
            
        }
    }

    private void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
