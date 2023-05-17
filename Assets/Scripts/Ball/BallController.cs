using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private PlatformMove _platformMove;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basket"))
        {
            _platformMove.Basket();
        }
        else if (other.CompareTag("Finish"))
        {
            _platformMove.Lose();
        }
    }
}
