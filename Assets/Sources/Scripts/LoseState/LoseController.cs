using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;

public class LoseController : GameSystem, IIniting
{
    void IIniting.OnInit()
    {
        foreach (var joint in game.joints)
        {
            joint.enabled = false;
        }
    }
}
