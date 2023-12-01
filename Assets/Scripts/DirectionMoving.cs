using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionMoving : MonoBehaviour
{

    [SerializeField] private int _movingSpeed;


    void Update()
    {
        transform.Translate(_movingSpeed * Time.deltaTime, 0, 0);
    }
}
