using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 position)
    {
        OnMoveEvent?.Invoke(position);
    }

    public void CallLookEvent(Vector2 position)
    {
        OnLookEvent?.Invoke(position);
    }
}
