using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour {

    [SerializeField] Defender defenderPrefab;

    private void OnMouseDown() {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons) {
            // Color32 is used in RGB 0 - 255
            button.GetComponent<SpriteRenderer>().color = new Color32(92, 85, 85, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }
}
