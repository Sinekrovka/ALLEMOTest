using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;

public class FinishController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Bootstrap.GetCurrentGamestate().Equals(EGamestate.Game))
        {
            Bootstrap.ChangeGameState(EGamestate.Win);
        }
    }
}
