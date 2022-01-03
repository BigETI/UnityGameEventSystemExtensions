using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "CharGameEvent", menuName = "Game events/System/Game event (Char)")]
    public class SystemCharGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Char>, ISystemCharGameEventListenerObject
    {
        // ...
    }
}
