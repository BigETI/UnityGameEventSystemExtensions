using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "UInt16GameEvent", menuName = "Game events/System/Game event (UInt16)")]
    public class SystemUInt16GameEventListenerObjectScript : AGameEventWithParameterObjectScript<UInt16>, ISystemUInt16GameEventListenerObject
    {
        // ...
    }
}
