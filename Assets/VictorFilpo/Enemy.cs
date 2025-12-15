using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 baseLocalPosition; 
    private bool isReturning = false;

    public float respawnDelay = 1.5f;   
    public float returnSpeed = 3f;      

    void Start()
    {
        baseLocalPosition = transform.localPosition;
    }

    void Update()
    {
        if (isReturning) return;

        Vector3 viewportPos = Camera.main.WorldToViewportPoint(transform.position);

        if (viewportPos.x < -0.1f || viewportPos.x > 1.1f || viewportPos.y < -0.1f || viewportPos.y > 1.1f)
        {
            StartCoroutine(ReturnToFormation());
        }
    }

    private IEnumerator ReturnToFormation()
    {
        isReturning = true;

        yield return new WaitForSeconds(respawnDelay);

        Vector3 startWorldPos = transform.position;
        Vector3 endWorldPos = transform.parent.TransformPoint(baseLocalPosition);
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime * returnSpeed;
            transform.position = Vector3.Lerp(startWorldPos, endWorldPos, t);
            yield return null;
        }

        transform.localPosition = baseLocalPosition;
        isReturning = false;
    }
}