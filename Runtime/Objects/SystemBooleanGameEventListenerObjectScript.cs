using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "BooleanGameEvent", menuName = "Game events/System/Game event (Boolean)")]
    public class SystemBooleanGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Boolean>, ISystemBooleanGameEventListenerObject
    {
        // ...
    }
}
