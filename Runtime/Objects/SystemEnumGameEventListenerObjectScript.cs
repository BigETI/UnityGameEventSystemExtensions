using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "EnumGameEvent", menuName = "Game events/System/Game event (Enum)")]
    public class SystemEnumGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Enum>, ISystemEnumGameEventListenerObject
    {
        // ...
    }
}
