using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;

    void Update()
    {
        if (target)
        {
            Vector3 newPosition = target.position + offset;
            newPosition.x = 0;
            transform.position = newPosition; 
        }
    }
}