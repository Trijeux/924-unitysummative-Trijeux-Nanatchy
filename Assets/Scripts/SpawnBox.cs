// Project : 924 Exam Module 2
// Script by : Nanatchy

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class SpawnBox : MonoBehaviour
{
    #region Attributs

    [SerializeField] private List<GameObject> boxs;

    [SerializeField] private LimitBox limitBox;

    private bool _coroutineStart = false;
    
    #endregion

    #region Methods

    private void Spawn()
    {
	    int randomBox = Random.Range(0, boxs.Count - 1);
	    Instantiate(boxs[randomBox], new Vector3(transform.parent.position.x,transform.parent.position.y + 0.5f,transform.parent.position.z),Quaternion.Euler(0,0,0));
    }

    #endregion

    #region Behaviors
	
	private void Start()
	{
		Spawn();
	}
	
    private void Update()
    {
	    if (!limitBox.HaveBox && !_coroutineStart)
	    {
		    StartCoroutine(nameof(SpawnTime));
		    _coroutineStart = true;
	    }
    }
    
    #endregion

    private IEnumerator SpawnTime()
    {
	    yield return new WaitForSeconds(2f);
	    Spawn();
	    _coroutineStart = false;
    }

}
