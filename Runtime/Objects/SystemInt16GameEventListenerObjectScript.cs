using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "Int16GameEvent", menuName = "Game events/System/Game event (Int16)")]
    public class SystemInt16GameEventListenerObjectScript : AGameEventWithParameterObjectScript<Int16>, ISystemInt16GameEventListenerObject
    {
        // ...
    }
}
