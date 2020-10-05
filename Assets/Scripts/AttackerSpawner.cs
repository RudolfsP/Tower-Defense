using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour {

    bool spawn = true;
    [SerializeField] float minSpawnInterval = 1f;
    [SerializeField] float maxSpawnInterval = 5f;
    [SerializeField] Attacker attackerPrefab;

    IEnumerator Start() {
        while (spawn) {
            yield return new WaitForSeconds(Random.Range(minSpawnInterval, maxSpawnInterval));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker() {
        Instantiate(
            attackerPrefab,
            transform.position,
            Quaternion.identity
            );
    }

    // Update is called once per frame
    void Update() {
        
    }
}
