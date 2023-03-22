using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject _target;
    private Vector3 _offset;

    void Start()
    {
        _offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 _targetPos = _target.transform.position;

        transform.position = _targetPos + _offset;
    }
}
