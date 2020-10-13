using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour {
    // Start is called before the first frame update

    private void OnTriggerEnter2D() {
        FindObjectOfType<LivesDisplay>().TakeLife();
    }

}
