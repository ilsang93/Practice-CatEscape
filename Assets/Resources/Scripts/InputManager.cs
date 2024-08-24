using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    public Action leftAction;
    public Action rightAction;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else {
            DestroyImmediate(this);
        }
    }

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
            leftAction?.Invoke();
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
            rightAction?.Invoke();
        }
    }

    public void GameOver() {
        leftAction = null;
        rightAction = null;
    }
}
