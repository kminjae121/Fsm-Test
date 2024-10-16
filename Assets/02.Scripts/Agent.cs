using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Agent : MonoBehaviour
{
    protected Rigidbody2D _rigid;
    protected int Speed;
    protected int Hp;
    protected int AttackDamage;


    public virtual void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }
}