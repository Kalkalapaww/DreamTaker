using UnityEngine;

public class Cloud : MonoBehaviour
{
    public GameManager gameManager;
    public float amplitude = 0.5f;
    public float frequency = 1f;
    void Update()
    {
        transform.Translate(new Vector2(1, Mathf.Sin(Time.time * frequency) * amplitude) * Time.deltaTime);
        if (transform.position.x > 10f)
        {
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        gameManager.AddScore(1);
        Destroy(gameObject);
    }
}
