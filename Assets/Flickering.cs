using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flickering : MonoBehaviour
{

    public float MinTime;
    public float MaxTime;
    public float Timer;

    void Start()
    {
        Timer = Random.Range(MinTime, MaxTime);
    }

    void Update()
    {
        
    }

    void Flicker() {
        if (Timer > 0) {
            Timer = Timer - Time.deltaTime;
        }

        if (Timer <= 0) {
            gameObject.SetActive(!gameObject.activeSelf);
            Timer = Random.Range(MinTime, MaxTime);
        }
    }
}
