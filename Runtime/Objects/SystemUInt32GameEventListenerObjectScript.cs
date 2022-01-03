using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "UInt32GameEvent", menuName = "Game events/System/Game event (UInt32)")]
    public class SystemUInt32GameEventListenerObjectScript : AGameEventWithParameterObjectScript<UInt32>, ISystemUInt32GameEventListenerObject
    {
        // ...
    }
}
