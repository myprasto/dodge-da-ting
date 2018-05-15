using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

    public static int score;

    // Update is called once per frame
    void Update () {

        if (transform.position.y < -1.3f)
        {
            score += 1;
            Debug.Log(score);
            Destroy(gameObject);
        }

	}
}
