using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChanging : MonoBehaviour
{
    [SerializeField] private int _growingSpeed;
    [SerializeField] private int _growingCoefficient;

    private Vector3 _defaultScale;
    private Vector3 _maxScale;
    private int _directionSign;

    private void Start()
    {
        _directionSign = 1;
        _defaultScale = transform.localScale;
        _maxScale = transform.localScale * _growingCoefficient;
    }

    void Update()
    {
        int signChanger = -1;


        float changingNumber = _growingSpeed * Time.deltaTime * _directionSign;
        Vector3 tempVector = new Vector3(changingNumber, changingNumber, changingNumber);

        transform.localScale += tempVector;

        if (transform.localScale.x > _maxScale.x)
        {
            transform.localScale = _maxScale;
            _directionSign *= signChanger;
        }
        else if (transform.localScale.x < _defaultScale.x)
        {
            transform.localScale = _defaultScale;
            _directionSign *= signChanger;
        }
    }
}
