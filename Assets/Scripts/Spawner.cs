using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private float _timeToDelayCreatingEnemy;

    private Coroutine _spawningEnemy;

    private void Awake()
    {
        _spawnPoints = GetComponentsInChildren<SpawnPoint>();
    }

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&_spawningEnemy==null)
        {
            _spawningEnemy=StartCoroutine(CreateEnemyByTime());
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            StopCoroutine(_spawningEnemy);
        }
    }

    private IEnumerator CreateEnemyByTime()
    {
        while (true)
        {
            Instantiate(_enemy, _spawnPoints[Random.Range(0, _spawnPoints.Length)].transform);
            yield return new WaitForSecondsRealtime(_timeToDelayCreatingEnemy);
        }        
    }
}
