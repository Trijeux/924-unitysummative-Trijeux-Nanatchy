// Project : 924 Exam Module 2
// Script by : Nanatchy

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    #region Attributs

    private Vector2 _move = new Vector2(0,0);
    private Rigidbody _rigidbody;
    [SerializeField] private float forceMove = 5f;

    #endregion

    #region Methods

    public void InputMove(InputAction.CallbackContext context)
    {
       _move = context.ReadValue<Vector2>();
    }

    #endregion

    #region Behaviors

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Calculer la direction locale
        Vector3 moveDirection = transform.right * _move.x + transform.forward * _move.y;

        // Appliquer le mouvement dans l'espace local
        _rigidbody.linearVelocity = new Vector3(moveDirection.x * forceMove, _rigidbody.linearVelocity.y, moveDirection.z * forceMove);
    }

    #endregion
}
