using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Apple : MonoBehaviour {                                    // a
    public static float bottomY = -20f;                             // b  
    void Update() {
        if (transform.position.y < bottomY) {
            Destroy(this.gameObject);                                 // c

            // Get a reference to the ApplePicker component of Main Camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();           // b
            // Call the public AppleMissed() method of apScript
            apScript.AppleMissed();                                                   // c
        }                                                                             // a
    }
}
