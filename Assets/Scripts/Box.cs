using System;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private float boxSpeed;
    private bool _isMoveLimit;

    private void Move()
    {
        transform.position += new Vector3(boxSpeed * Time.deltaTime,0, 0);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isMoveLimit)
        {
            Move();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.CompareTag("Limit"))
        {
            _isMoveLimit = true;
        }
    }
}
