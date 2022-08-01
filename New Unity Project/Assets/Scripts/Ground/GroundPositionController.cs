using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{
    private GroundSpawnController groundSpawnController;
    private Rigidbody rb;
    [SerializeField] private float endYValue;
    private int groundDirection;
    void Start()
    {
        groundSpawnController = FindObjectOfType<GroundSpawnController>();
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        CheckGroundVerticalPosition();
    }


    private void CheckGroundVerticalPosition()
    {
        if (transform.position.y <= endYValue)
        {
            SetRigidBodyValues();
            groundDirection = Random.Range(0, 2);



            if (groundDirection == 0)
            {
                transform.position = new Vector3(groundSpawnController.lastGround.transform.position.x - 1, groundSpawnController.lastGround.transform.position.y, groundSpawnController.lastGround.transform.position.z);
            }
            else
            {
                transform.position = new Vector3(groundSpawnController.lastGround.transform.position.x, groundSpawnController.lastGround.transform.position.y, groundSpawnController.lastGround.transform.position.z + 1);
            }


            groundSpawnController.lastGround = gameObject;


        }
    }
    private void SetRigidBodyValues()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }

}
