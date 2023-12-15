using UnityEngine;

public class Line : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
        _lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lineRenderer.positionCount = 0;
        }

        if (Input.GetMouseButton(0))
        {
            var mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
            var pointPosition = _camera.ScreenToWorldPoint(mousePosition);
            _lineRenderer.SetPosition(_lineRenderer.positionCount++, pointPosition);
        }
    }
}
