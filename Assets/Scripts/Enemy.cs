using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]private float _maxTimeOfLife;

    private float _timeOfLife;

    private void OnEnable()
    {
        _timeOfLife = 0;
    }

    void Update()
    {
        _timeOfLife += Time.deltaTime;

        if (_timeOfLife > _maxTimeOfLife)
        {
            Destroy(gameObject);
        }
    }
}
