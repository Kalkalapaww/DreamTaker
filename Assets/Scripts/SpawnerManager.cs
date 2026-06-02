using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public GameObject cloudPrefab;
    public Transform spawnPoint;
    public float timeBetweenSpawns = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnCloud", 0f, timeBetweenSpawns);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnCloud()
    {
        GameObject cloud = Instantiate(cloudPrefab, spawnPoint.position, Quaternion.identity);
        Cloud cloudScript = cloud.GetComponent<Cloud>();
        cloudScript.amplitude = Random.Range(0.3f, 0.7f);
        cloudScript.frequency = Random.Range(0.5f, 1.5f);
        cloud.SetActive(true);
        timeBetweenSpawns = Random.Range(3f, 5f);
    }
}
