using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;

public class WinParticle : GameSystem, IIniting
{
    void IIniting.OnInit()
    {
        foreach (var joint in game.joints)
        {
            joint.enabled = false;
        }
    }
}
