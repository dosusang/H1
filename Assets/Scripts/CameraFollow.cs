using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // 要跟随的目标物体
    public float armLength = 5.0f;  // 相机臂长
    public Vector3 cameraEulerAngles = new Vector3(45.0f, 0.0f, 0.0f);  // 相机欧拉角

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("未设置跟随的目标物体");
            return;
        }

        transform.rotation = Quaternion.Euler(cameraEulerAngles);
        transform.position = target.position - transform.rotation * Vector3.forward * armLength;
    }
}