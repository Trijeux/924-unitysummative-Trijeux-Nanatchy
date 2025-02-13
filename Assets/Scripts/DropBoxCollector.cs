// Project : 924 Exam Module 2
// Script by : Nanatchy

using System;
using TMPro;
using UnityEngine;

public class DropBoxCollector : MonoBehaviour
{
    #region Attributs

    [SerializeField] private TextMeshProUGUI count;
    [SerializeField] private GameObject player;
    [SerializeField] private Timer _timer;
    [SerializeField] private GameObject End;
    [SerializeField] private GameObject UI;
    [SerializeField] private TextMeshProUGUI Score;
    private int _box = 0;

    #endregion

    #region Methods



    #endregion

    #region Behaviors
	
	private void Start()
    {
        
    }
	
    private void Update()
    {
	    count.text = "Total " + "Box " + ": " + _box;
	    if (_timer.TimeEnd)
	    {
		    player.SetActive(false);
		    UI.SetActive(false);
		    End.SetActive(true);
		    Score.text = "Your " + "Score " + "Is " + ": " +  _box + " Box";
	    }
    }

    private void OnTriggerEnter(Collider other)
    {
	    if (other.CompareTag("Box"))
	    {
		    Destroy(other.gameObject);
		    _box++;
	    }
    }

    #endregion
}
