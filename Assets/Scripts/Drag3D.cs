using UnityEngine;

public class Draggable3D : MonoBehaviour
{
    private Vector3 offset;
    private Camera mainCamera;
    public Vector3 spawnAreaMin;
    public Vector3 spawnAreaMax;


    private void Start()
{
    mainCamera = Camera.main;
}

private void OnMouseDown()
{
    offset = gameObject.transform.position - GetMouseWorldPos();
}

private void OnMouseDrag()
{
    transform.position = GetMouseWorldPos() + offset;
}

private Vector3 GetMouseWorldPos()
{
    Vector3 mousePoint = Input.mousePosition;

    // Adjust for Z position to avoid moving the object too close or too far
    mousePoint.z = Mathf.Abs(mainCamera.WorldToScreenPoint(transform.position).z);

    return mainCamera.ScreenToWorldPoint(mousePoint);
}
    void OnDrawGizmosSelected()
    {
        // Draw the spawn area gizmo in the Unity Editor
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, spawnAreaMax - spawnAreaMin);
    }

}
