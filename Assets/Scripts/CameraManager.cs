using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private CameraFollow cameraFollow;


    public void StartToFollowCamera(Transform transform)
    {
        cameraFollow.StartFollow(transform);
    }

    public void StopTheFollowCamera(Transform transform)
    {
        cameraFollow.StopFollow();
    }
   
}
