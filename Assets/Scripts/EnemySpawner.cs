using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Transform spawnLocation;
    [SerializeField] GameObject[] enemies;
    private float lastSpawnTime;
    [SerializeField] float secondsPerSpawn;

    private void Awake()
    {
        lastSpawnTime = Time.time;
        Spawn();
    }

    private void Update()
    {
        secondsPerSpawn -= (0.05f * Time.deltaTime);
        if (Time.time - lastSpawnTime >= secondsPerSpawn && FPSPlayer.instance.ShouldSpawn(spawnLocation.position))
        {
            lastSpawnTime = Time.time;
            Spawn();
        }
    }

    private void Spawn()
    {
        GameObject enemyPrefab = enemies[Random.Range(0, enemies.Length)];
        GameObject newEnemy = Instantiate(enemyPrefab);
        newEnemy.transform.position = spawnLocation.position;
    }
}
