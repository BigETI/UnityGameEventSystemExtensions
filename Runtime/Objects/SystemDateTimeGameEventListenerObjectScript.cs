using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "DateTimeGameEvent", menuName = "Game events/System/Game event (DateTime)")]
    public class SystemDateTimeGameEventListenerObjectScript : AGameEventWithParameterObjectScript<DateTime>, ISystemDateTimeGameEventListenerObject
    {
        // ...
    }
}
