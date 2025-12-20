using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform transformToFollow;
    private bool isFollowing = false;
    private Vector3 newPosition;

    [SerializeField] private Vector3 offset;

    public void StartFollow(Transform transformToFollow)
    {
        isFollowing = true;
        this.transformToFollow = transformToFollow;

    }
    public void StopFollow()
    {
        isFollowing = true;
    }

    private void LateUpdate()
    {
        if (!isFollowing || !transformToFollow)
        {
            return;
        }
        newPosition = new Vector3(transformToFollow.position.x, 0f, transformToFollow.position.z) + offset;
        transform.position = newPosition;
    }
}
