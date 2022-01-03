using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "GuidGameEvent", menuName = "Game events/System/Game event (Guid)")]
    public class SystemGuidGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Guid>, ISystemGuidGameEventListenerObject
    {
        // ...
    }
}
