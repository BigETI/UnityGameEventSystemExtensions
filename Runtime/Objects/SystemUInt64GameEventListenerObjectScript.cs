using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "UInt64GameEvent", menuName = "Game events/System/Game event (UInt64)")]
    public class SystemUInt64GameEventListenerObjectScript : AGameEventWithParameterObjectScript<UInt64>, ISystemUInt64GameEventListenerObject
    {
        // ...
    }
}
