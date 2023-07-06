using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimEvents : MonoBehaviour
{
    public static bool IsHitting { get; private set; } = false;

    void AttackHit(int nr)
    {
        IsHitting = true;
    }

    void AttackFinish(int nr)
    {
        IsHitting = false;
    }
}
