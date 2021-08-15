using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "newChargeStateData", menuName = "Data/State Data/Charge state")]

public class D_ChargeState : ScriptableObject
{
    public float chargeSpeed = 4f;
    public float chargeTime = 2f;
}
