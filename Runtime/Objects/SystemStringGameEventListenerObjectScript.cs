using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "StringGameEvent", menuName = "Game events/System/Game event (String)")]
    public class SystemStringGameEventListenerObjectScript : AGameEventWithParameterObjectScript<String>, ISystemStringGameEventListenerObject
    {
        // ...
    }
}
