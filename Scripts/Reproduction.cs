using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproduction : MonoBehaviour
{
	[SerializeField] private GameObject _enemy;
	[SerializeField] private float _waitTime = 2f;
	[SerializeField] private float _time = 0f;

	private void Start()
	{
		while (_time <= 10)
		{
			StartCoroutine(SpawnEnemy());
		}
	}

	private IEnumerator SpawnEnemy()
	{
		var waitForOneSeconds = new WaitForSeconds(1f);

		_time++;

		Instantiate(_enemy, transform.position, transform.rotation);

		if (_time >= 10)
			{
			yield break;
		}

		if (_waitTime > .2f)
		{
			Invoke(nameof(SpawnEnemy), _waitTime);
		}

		yield return waitForOneSeconds;
	}
}