using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject Robot;
    public GameObject CenterEyeAnchor; 

    private Rigidbody _robotRb;
    private CharacterController _robotController;
    private Quaternion _robotInitialRotation;

    void Start()
    {
        _robotRb = Robot.GetComponent<Rigidbody>();
        _robotController = Robot.GetComponent<CharacterController>();
        _robotInitialRotation = Robot.transform.rotation;
    }

    void Update()
    {
        // A button
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            _robotController.enabled = false;

            _robotRb.velocity = Vector3.zero;
            _robotRb.angularVelocity = Vector3.zero;
            Robot.transform.position = CenterEyeAnchor.transform.position + CenterEyeAnchor.transform.forward;
            Robot.transform.rotation = _robotInitialRotation;

            _robotController.enabled = true;
        }
    }
}
