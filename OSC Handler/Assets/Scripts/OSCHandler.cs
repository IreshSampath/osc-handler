using extOSC;
using UnityEngine;

public class OSCHandler : MonoBehaviour
{
    #region Fields

    [Header("OSC Settings")]
    public OSCReceiver Receiver;

    string AddressAdd = "/Cursor/Added";
    string AddressUpdate = "/Cursor/Updated";
    string AddressDelete = "/Cursor/Removed";

    #endregion


    #region Unity Methods

    protected virtual void Start()
    {
        Receiver.Bind(AddressAdd, ReceivedMessageFromAdded);
        Receiver.Bind(AddressUpdate, ReceivedMessageFromMoved);
        Receiver.Bind(AddressDelete, ReceivedMessageFromRemoved);
    }

    #endregion


    #region Private Methods

    void ReceivedMessageFromAdded(OSCMessage message)
    {

        if (message.ToString(out var value))
        {
            Events.OnCursorAdded?.Invoke(value);
        }
    }

    void ReceivedMessageFromMoved(OSCMessage message)
    {
        if (message.ToString(out var value))
        {
            Events.OnCursorUpdated?.Invoke(value);
        }
    }

    void ReceivedMessageFromRemoved(OSCMessage message)
    {
        if (message.ToInt(out var value))
        {
            Events.OnCursorRemoved?.Invoke(value);
        }
    }

    #endregion
}
