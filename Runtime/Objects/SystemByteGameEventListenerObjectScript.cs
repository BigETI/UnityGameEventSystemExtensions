using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "ByteGameEvent", menuName = "Game events/System/Game event (Byte)")]
    public class SystemByteGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Byte>, ISystemByteGameEventListenerObject
    {
        // ...
    }
}
