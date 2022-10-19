using UnityEngine;

public class CCameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _targetCamera;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeTargetPosition();
        }
    }

    private void ChangeTargetPosition()
    {
        float newX = _targetCamera.position.x - 6f;
        _targetCamera.position = new Vector3(newX, _targetCamera.position.y, _targetCamera.position.z);
    }
}
