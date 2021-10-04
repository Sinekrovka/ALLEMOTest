using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;

public class CameraController : GameSystem, IIniting, IUpdating
{
    private float ZPosition;
    private Vector3 currentPosition;
    void IIniting.OnInit()
    {
        ZPosition = game.camera.position.z;
    }

    void IUpdating.OnUpdate()
    {
        currentPosition = game.player.position;
        currentPosition.z = ZPosition;
        game.camera.position = currentPosition;
    }
}
