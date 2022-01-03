using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "DateTimeOffsetGameEvent", menuName = "Game events/System/Game event (DateTimeOffset)")]
    public class SystemDateTimeOffsetGameEventListenerObjectScript : AGameEventWithParameterObjectScript<DateTimeOffset>, ISystemDateTimeOffsetGameEventListenerObject
    {
        // ...
    }
}
