using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "DelegateGameEvent", menuName = "Game events/System/Game event (Delegate)")]
    public class SystemDelegateGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Delegate>, ISystemDelegateGameEventListenerObject
    {
        // ...
    }
}
