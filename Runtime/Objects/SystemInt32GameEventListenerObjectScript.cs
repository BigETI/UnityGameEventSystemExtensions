using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "Int32GameEvent", menuName = "Game events/System/Game event (Int32)")]
    public class SystemInt32GameEventListenerObjectScript : AGameEventWithParameterObjectScript<Int32>, ISystemInt32GameEventListenerObject
    {
        // ...
    }
}
