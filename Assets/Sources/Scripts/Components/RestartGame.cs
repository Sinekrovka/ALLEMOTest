using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
    public void RestartGameButton()
    {
        Bootstrap.GameRestart(0);
    }
}
