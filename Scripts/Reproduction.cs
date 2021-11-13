using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproduction : MonoBehaviour
{
	[SerializeField] private GameObject _enemy;
	[SerializeField] private float _waitTime = 2f;
	[SerializeField] private float endSpawn = 10;

	private void Start()
	{
		while (_waitTime <= endSpawn)
		{
			StartCoroutine(SpawnEnemy());
		}
	}

	private IEnumerator SpawnEnemy()
	{
		_waitTime++;

		Instantiate(_enemy, transform.position, transform.rotation);

		yield return _waitTime;
	}
}