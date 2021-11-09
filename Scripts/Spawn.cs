using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	[SerializeField] private GameObject _enemy;
	[SerializeField] private float _waitTime = 2f;

	private void Start()
	{
		Invoke(nameof(SpawnEnemy), _waitTime);
	}

	private void SpawnEnemy()
	{
		Instantiate(_enemy, transform.position, transform.rotation);

		if (_waitTime > .2f)
		{
			Invoke(nameof(SpawnEnemy), _waitTime);
		}
	}
}