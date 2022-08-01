using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;
    private Vector3 offset;
    private Vector3 newPosition;

    [SerializeField][Range(0, 3)] private float lerpValue;
    void Start()
    {
        offset = transform.position - ballTransform.position;
    }



    void LateUpdate()
    {
        CameraFollow();
    }
    private void CameraFollow()
    {
        //Lerp Fonskiyonu => Vector3.Lerp(transform.position,new Vector3( ,  ,  ), lerpValue)
        newPosition = Vector3.Lerp(transform.position, ballTransform.position + offset/*(topun oldugu pozisyona git ama aradaki mesafeyi koru)*/, lerpValue * Time.deltaTime);
        transform.position = newPosition;


    }



}
