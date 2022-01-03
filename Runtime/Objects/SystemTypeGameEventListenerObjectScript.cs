using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "TypeGameEvent", menuName = "Game events/System/Game event (Type)")]
    public class SystemTypeGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Type>, ISystemTypeGameEventListenerObject
    {
        // ...
    }
}
