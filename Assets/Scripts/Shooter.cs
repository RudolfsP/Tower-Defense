using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    [SerializeField] GameObject projectile;
    [SerializeField] GameObject gun;
    AttackerSpawner myLaneSpawner;
    Animator animator;

    private void Start() {
        //FindObjectOfType should be used for scripts but GetComponent can be used for components
        //on the currenyt gameObject
        SetLaneSpawner();
        animator = GetComponent<Animator>();
    }

    private void Update() {

        if (IsAttackerInLane()) {
            animator.SetBool("isAttacking", true);
        }

        else {
            animator.SetBool("isAttacking", false);
        }
    }

    private void SetLaneSpawner() {
        AttackerSpawner[] attackerSpawners = FindObjectsOfType<AttackerSpawner>();

        foreach(AttackerSpawner spawner in attackerSpawners) {
            bool isCloseEnough = 
                (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);

            if (isCloseEnough) {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane() { 
        //if my lane spawner child count <= 0 then return false
        if ((myLaneSpawner == null) || (myLaneSpawner.transform.childCount <= 0)) {
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
