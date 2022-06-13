using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform Player;
    public float tlerp=0.2f;
    public float rlerp = 0.01f;
    private void Update()
    {

        transform.position = Vector3.Lerp(transform.position, Player.position , tlerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, Player.rotation, rlerp);

    }

}
    