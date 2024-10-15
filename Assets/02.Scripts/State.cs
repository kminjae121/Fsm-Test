using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State<T> where T: class
{
    public abstract void Enter(T obj);

    public abstract void Execute(T obj);

    public abstract void Exit(T obj);
}
