using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproduction : MonoBehaviour
{
	[SerializeField] private GameObject _enemy;
	[SerializeField] private float _waitTime = 2f;
	[SerializeField] private float Time = 0f;

	private void Start()
	{
		Invoke(nameof(SpawnEnemy), _waitTime);
	}

	private void SpawnEnemy()
	{
		Time++;

		Instantiate(_enemy, transform.position, transform.rotation);

		if (Time >= 10)
        {
			return;
        }

		if (_waitTime > .2f)
		{
			Invoke(nameof(SpawnEnemy), _waitTime);
		}

	}
}