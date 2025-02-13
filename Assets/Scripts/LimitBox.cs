// Project : 924 Exam Module 2
// Script by : Nanatchy

using System;
using UnityEngine;

public class LimitBox : MonoBehaviour
{
    #region Attributs
    public bool HaveBox { get; private set; } = false;

    #endregion

    #region Methods

	

    #endregion

    #region Behaviors
	
	private void Start()
    {
        
    }
	
    private void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
	    HaveBox = other.CompareTag("Box");
    }

    private void OnTriggerExit(Collider other)
    {
	    HaveBox = false;
    }

    #endregion
}
