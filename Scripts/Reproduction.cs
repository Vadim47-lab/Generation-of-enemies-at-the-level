using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameObject))]
public class Reproduction : MonoBehaviour
{
	[SerializeField] private Enemy _enemy = new Enemy();

	private void Start()
	{
		StartCoroutine(SpawnEnemy());
	}

	private IEnumerator SpawnEnemy()
	{
		var waitForSeconds = new WaitForSeconds(2f);

		while (true)
		{
		    Instantiate(_enemy, transform.position, transform.rotation);

		    yield return waitForSeconds;
		}
	}
}