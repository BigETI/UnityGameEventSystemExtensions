using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "SByteGameEvent", menuName = "Game events/System/Game event (SByte)")]
    public class SystemSByteGameEventListenerObjectScript : AGameEventWithParameterObjectScript<SByte>, ISystemSByteGameEventListenerObject
    {
        // ...
    }
}
