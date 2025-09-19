using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Apple : MonoBehaviour {                                    // a
    public static float bottomY = -20f;                             // b  
    void Update() {
        if (transform.position.y < bottomY) {
            Destroy(this.gameObject);                                 // c
        }
    }

    // void Start() {…}  // Please delete the unused Start() method
}
