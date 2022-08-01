using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmitter : MonoBehaviour
{
    //Bu class'ın amacı verileri birbirine taşımak olacak 
    [SerializeField] private BallInputController ballInputController;

    public Vector3 GetBallDirection()
    {
        return ballInputController.ballDirection;
    }

}
