using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject Robot;

    private Rigidbody _robotRb;
    private Vector3 _robotInitialPosition;
    private Quaternion _robotInitialRotation;

    void Start()
    {
        _robotRb = Robot.GetComponent<Rigidbody>();
        _robotInitialPosition = Robot.transform.position;
        _robotInitialRotation = Robot.transform.rotation;
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One)) // A button
        {
            _robotRb.velocity = Vector3.zero;
            _robotRb.angularVelocity = Vector3.zero;
            Robot.transform.position = _robotInitialPosition;
            Robot.transform.rotation = _robotInitialRotation;
        }
    }
}
