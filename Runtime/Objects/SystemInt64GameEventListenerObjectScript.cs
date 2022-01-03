using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "Int64GameEvent", menuName = "Game events/System/Game event (Int64)")]
    public class SystemInt64GameEventListenerObjectScript : AGameEventWithParameterObjectScript<Int64>, ISystemInt64GameEventListenerObject
    {
        // ...
    }
}
