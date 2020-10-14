using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour {

    bool spawn = true;
    [SerializeField] float minSpawnInterval = 1f;
    [SerializeField] float maxSpawnInterval = 5f;
    [SerializeField] Attacker[] attackerPrefabs;

    IEnumerator Start() {
        while (spawn) {
            yield return new WaitForSeconds(Random.Range(minSpawnInterval, maxSpawnInterval));
            SpawnAttacker();
        }
    }

    public void StopSpawning() {
        spawn = false;
    }


    private void SpawnAttacker() {
        var attackerIndex = Random.Range(0, attackerPrefabs.Length);
        Spawn(attackerPrefabs[attackerIndex]);
    }

    private void Spawn(Attacker attackerPrefab) {
        Attacker attacker = Instantiate(
            attackerPrefab,
            transform.position,
            Quaternion.identity) as Attacker;

        //the parent of this new attacker is transform
        attacker.transform.parent = transform;
    }

}
