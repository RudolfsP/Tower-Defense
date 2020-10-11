using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    [SerializeField] GameObject projectile;
    [SerializeField] GameObject gun;
    AttackerSpawner myLaneSpawner;

    private void Start() {
        SetLaneSpawner();
    }

    private void Update() {

        if (IsAttackerInLane()) {
            Debug.Log("Shoot");
            //TODO change animation state to shooting
        }

        else {
            Debug.Log("Attacker not in lane");
            //TODO change animation state to idle
        }
    }

    private void SetLaneSpawner() {
        AttackerSpawner[] attackerSpawners = FindObjectsOfType<AttackerSpawner>();

        foreach(AttackerSpawner spawner in attackerSpawners) {
            bool isCloseEnough = 
                (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);

            if(isCloseEnough) {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane() {
        //if my lane spawner child count <= 0 then return false
        if(myLaneSpawner.transform.childCount <= 0) {
            return false;
        }
        else {
            return true;
        } 
    }

    public void Fire() {
        Instantiate(projectile, gun.transform.position, Quaternion.identity);
    }

}
