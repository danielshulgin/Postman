using System;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private Camera _camera;

    private Vector3 _startOffset;


    private void Awake()
    {
        _camera = Camera.main;
        _startOffset = _camera.transform.position - playerTransform.position;
    }

    private void Update()
    {
        MoveCameraToPlayer();
    }

    private void MoveCameraToPlayer()
    {
        var targetPosition = playerTransform.position + _startOffset;
        _camera.transform.position = new Vector3(
            Mathf.Lerp(_camera.transform.position.x, targetPosition.x, 0.1f), 
            _camera.transform.position.y, 
            Mathf.Lerp(_camera.transform.position.z, targetPosition.z, 0.1f));
    }
}
