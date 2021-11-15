using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameObject))]
public class Reproduction : MonoBehaviour
{
	[SerializeField] private GameObject _target;

	private void Start()
	{
		_target = gameObject.GetComponent<GameObject>();
		StartCoroutine(SpawnEnemy());
	}

	private IEnumerator SpawnEnemy()
	{
		var waitForSeconds = new WaitForSeconds(2f);

		while (true)
		{
		    Instantiate(_target, transform.position, transform.rotation);

			yield return waitForSeconds;
		}
	}
}