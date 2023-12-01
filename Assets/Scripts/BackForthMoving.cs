using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackForthMoving : MonoBehaviour
{
    [SerializeField] private int _movingSpeed;

    private int _directionSign;

    private void Start()
    {
        _directionSign = 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        int signChanger = -1;

        if (collision.collider.GetComponent<Terrain>() == true)
            _directionSign *= signChanger;
        
        Debug.Log("Коллизия!");
    }

    private void Update()
    {
            transform.Translate(0, 0, _movingSpeed * Time.deltaTime * _directionSign);
    }
}

