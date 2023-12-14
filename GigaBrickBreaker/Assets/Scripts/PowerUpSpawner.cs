using System.Collections;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject powerUpPrefab;

    private void Start()
    {
        StartCoroutine(SpawnPowerUps());
    }

    private IEnumerator SpawnPowerUps()
    {
        yield return new WaitForSeconds(15f);
        while (true)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-8f, 8f), 16f, 0f);
            Instantiate(powerUpPrefab, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(5f, 15f));
        }
    }
}