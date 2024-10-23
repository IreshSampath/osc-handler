using System;
using UnityEngine;

public class Events
{
    // for OSC data
    public static Action<string> OnCursorAdded;
    public static Action<string> OnCursorUpdated;
    public static Action<int> OnCursorRemoved;
}
