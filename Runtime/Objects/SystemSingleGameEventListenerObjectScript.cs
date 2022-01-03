using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "SingleGameEvent", menuName = "Game events/System/Game event (Single)")]
    public class SystemSingleGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Single>, ISystemSingleGameEventListenerObject
    {
        // ...
    }
}
