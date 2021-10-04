using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEditor;
using UnityEngine;

public class LoadObjectsScript : GameSystem, IIniting
{
    void IIniting.OnInit()
    {
        game.joints = FindObjectsOfType<JointMouseDrag>();
        foreach (var joint in game.joints)
        {
            joint.enabled = false;
        }

        game.player = GameObject.FindWithTag("Player").transform;
        game.camera = GameObject.FindWithTag("MainCamera").transform;
        Vector3 pos = game.player.position;
        pos.z = game.camera.position.z;
        game.camera.position = pos;
    }

    public void StartGame()
    {
        foreach (var joint in game.joints)
        {
            joint.enabled = true;
        }
        Bootstrap.ChangeGameState(EGamestate.Game);
    }
}
