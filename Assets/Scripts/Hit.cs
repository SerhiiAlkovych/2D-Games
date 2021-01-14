using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public int GetHit(int _damage , int _health)
    {
        int health = _health - _damage;

        if (health <= 0)
        {
            GameObject.FindObjectOfType<EnemyHealth>().OnDestroy();
        }
        return health;
    }
}
