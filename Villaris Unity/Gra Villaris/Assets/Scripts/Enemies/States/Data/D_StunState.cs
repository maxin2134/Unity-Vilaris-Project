﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "newStunStateData", menuName = "Data/State Data/Stun State")]

public class D_StunState : ScriptableObject
{
    public float stunTime = 1f;

    public float stunKnockBackTime = 0.2f;

    public Vector2 stunKnockBackAngle;

    public float stunKnockBackSpeed = 20f;
}
