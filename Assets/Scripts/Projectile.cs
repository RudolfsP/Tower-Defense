using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    [SerializeField] float speed = 1f;
    [SerializeField] float damage = 50f;

    void Update() {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        var attacker = collider.GetComponent<Attacker>();
        var health = attacker.GetComponent<Health>();

        if (attacker && health) {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
