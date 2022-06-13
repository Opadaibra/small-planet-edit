using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : MonoBehaviour
{
    [SerializeField]
    public float velocity;
    Vector3 direction;
    Animator animator;
    [SerializeField] float sturfingspeed = 720f;
    [SerializeField] public float movingspeed;

    int VelocityZHash;

    private void Start()
    {
        animator = GetComponent<Animator>();
        VelocityZHash = Animator.StringToHash("Velocity Z");
    }
    void Update()
    {
        direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        transform.Translate(direction*movingspeed*Time.deltaTime,Space.World);
        if(direction !=  Vector3.zero)
        {
            Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, sturfingspeed * Time.deltaTime);
        }
        bool forwardpressed = Input.GetKey(KeyCode.W);
        bool lefttPressed = Input.GetKey(KeyCode.A);
        bool rightPressed = Input.GetKey(KeyCode.D);
        bool downpressed = Input.GetKey(KeyCode.S);
        if(forwardpressed||lefttPressed||rightPressed||downpressed)
        {
            animator.SetFloat(VelocityZHash, 0.2f);
        }
        else
        {
            animator.SetFloat(VelocityZHash, 0);
        }
    }


}
