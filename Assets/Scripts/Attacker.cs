using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

    [Range(0f, 5f)]
    float currentSpeed = 1f;

    void Update() {
        //everything in the update method has to be multiplied by Time.deltaTime
        //to make things framerate independant
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed) {
        currentSpeed = speed;
    }

}
