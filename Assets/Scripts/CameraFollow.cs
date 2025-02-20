using UnityEngine;

public class CameraFollow : MonoBehaviour{
    [HideInInspector]
    public Vector3 targetPosition;

    private float smoothMove = 1f;

    void Start(){
        targetPosition = transform.position;
    }

    void Update(){
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothMove * Time.deltaTime);
    }
}
