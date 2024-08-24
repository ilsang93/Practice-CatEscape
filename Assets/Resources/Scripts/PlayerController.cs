using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        print(speed);
        InputManager.instance.leftAction += LeftMove;
        InputManager.instance.rightAction += RightMove;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LeftMove() {
        if (transform.position.x <= -9f) return;
        transform.Translate(-1 * speed, 0, 0);
    }

    private void RightMove() {
        if (transform.position.x >= 9f) return;
        transform.Translate(1 * speed, 0, 0);
    }
}
