
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInputController : MonoBehaviour
{
  [HideInInspector]  public Vector3 ballDirection;

    void Start()
    {
        ballDirection = Vector3.left;//Topumuz ilk başta sola doğru gitmeye başlayacak.
    }

    void Update()
    {
HandleBallInputs();
    }

    private void HandleBallInputs()
    {
        if (Input.GetMouseButtonDown(0))//Her sol tık yapıldıgında top yön değiştirecek
        {
            ChangeBallDirection();
        }
    }
    private void ChangeBallDirection()
    {
        if (ballDirection.x == -1)
        {
            ballDirection = Vector3.forward;//Top Yönü(Doğrultusu) x= -1 ise ileri(forward) git.
        }
        else
        {
            ballDirection = Vector3.left;//Kosul saglanmadıgında sola git
        }
    }
}
