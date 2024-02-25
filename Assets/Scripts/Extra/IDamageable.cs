using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    // any class that implements this interface must also interface the methods and properties within this interface

    void TakeDamage(float amount);
}
