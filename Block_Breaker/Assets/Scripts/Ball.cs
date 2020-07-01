using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    // config parameters
    [SerializeField] Paddle paddle1;
    // state
    Vector2 paddleToBallVector;

    void Start() {
        paddleToBallVector = transform.position - paddle1.transform.position;
    }

    void Update() {
        LockBallToPaddle();
    }

    private void LockBallToPaddle() {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }
}
