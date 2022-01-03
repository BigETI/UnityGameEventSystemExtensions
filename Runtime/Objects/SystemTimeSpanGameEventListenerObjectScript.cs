using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "TimeSpanGameEvent", menuName = "Game events/System/Game event (TimeSpan)")]
    public class SystemTimeSpanGameEventListenerObjectScript : AGameEventWithParameterObjectScript<TimeSpan>, ISystemTimeSpanGameEventListenerObject
    {
        // ...
    }
}
