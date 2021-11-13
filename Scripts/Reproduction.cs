using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproduction : MonoBehaviour
{
	[SerializeField] private GameObject _enemy;
	[SerializeField] private float _waitTime = 0f;
	[SerializeField] private float _endSpawn = 10;

	private void Start()
	{
		StartCoroutine(SpawnEnemy());
	}

	private IEnumerator SpawnEnemy()
	{
		while (_waitTime <= _endSpawn)
		{
			_waitTime += 2;

			Instantiate(_enemy, transform.position, transform.rotation);

			yield return _waitTime;
		}
	}
}