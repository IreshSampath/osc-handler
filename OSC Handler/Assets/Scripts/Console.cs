using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour
{
    private void OnEnable()
    {
        Events.OnCursorAdded += CreatePositions;
        Events.OnCursorUpdated += UpdatePositions;
        Events.OnCursorRemoved += RemovePosition;
    }

    private void OnDisable()
    {
        Events.OnCursorAdded -= CreatePositions;
        Events.OnCursorUpdated -= UpdatePositions;
        Events.OnCursorRemoved -= RemovePosition;
    }

    void CreatePositions(string msg)
    {
        print(msg);
    }

    void UpdatePositions(string msg)
    {
        print(msg);
    }

    void RemovePosition(int id)
    {
        print(id);
    }
}
