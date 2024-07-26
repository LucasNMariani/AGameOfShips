using UnityEngine;
using UnityEngine.Events;

public class OnCollisionDo : MonoBehaviour
{
    [SerializeField] private UnityEvent action;

    private GameObject _currentCollision;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this._currentCollision = collision.gameObject;
        action.Invoke();
    }

    void DestroyCurrentColision()
    {
        if (_currentCollision!= null) Destroy(_currentCollision);
    }
}
