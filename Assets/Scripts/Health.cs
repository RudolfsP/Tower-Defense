using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;
    /*
    [SerializeField] AudioClip deathSound;
    [SerializeField] [Range(0, 1)] float deathSoundVolume = 0.4f;
    
    */

    public void DealDamage(float damage) {
        health -= damage;

        if (health <= 0) {
            Die();
        }
    }

    public void Die() {
        TriggerDeathVFX();
        //AudioSource.PlayClipAtPoint(deathSound, Camera.main.transform.position, deathSoundVolume);
        Destroy(gameObject);


    }

    private void TriggerDeathVFX() {
        if(!deathVFX) { return; }
        GameObject particleEffect = Instantiate(deathVFX, transform.position, Quaternion.identity);
        Destroy(particleEffect, 1f);
    }

}
