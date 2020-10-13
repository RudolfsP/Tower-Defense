using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour {

    //[SerializeField] float damage = 20f;

    private void OnTriggerEnter2D(Collider2D otherCollider) {
        GameObject otherObject = otherCollider.gameObject;

        if (otherObject.GetComponent<Defender>()) {
            GetComponent<Attacker>().Attack(otherObject);
            //GetComponent<Attacker>().StrikeCurrentTarget(damage);
        }

    }
}
