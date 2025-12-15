using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyFormation : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 0.1f;          
    public float pauseDuration = 6f;
    private Vector3 startPos;

    private Vector3 direction = Vector3.right;
    private float minX, maxX;
    private bool isPaused = false;

    void Start()
    {
        float camDistance = Mathf.Abs(Camera.main.transform.position.z + transform.position.z);
        Vector3 leftEdge = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
        Vector3 rightEdge = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, camDistance));
        minX = leftEdge.x + 0.1f;
        maxX = rightEdge.x - 0.1f;

        startPos = transform.position;
    }

    void Update()
    {
        if (isPaused) return; 

        transform.Translate(this.direction * (this.speed * Time.deltaTime));

        foreach (Transform enemy in transform)
        {
            if (!enemy) continue;

            if (enemy.position.x < minX || enemy.position.x > maxX)
            {
                StartCoroutine(PauseAndReverse());
                break;
            }
        }

        if (transform.childCount <= 0)
        {
            Invoke(nameof(this.ResetGame), 1f);
        }
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private IEnumerator PauseAndReverse()
    {
        isPaused = true;

        transform.position += Vector3.down * 0.1f;

        yield return new WaitForSeconds(pauseDuration);

        direction = -direction;
        isPaused = false;
    }
}
