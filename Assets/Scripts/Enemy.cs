using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]private float _maxTimeOfLife;

    private void OnEnable()
    {
        Destroy(gameObject, _maxTimeOfLife);
    }
}
