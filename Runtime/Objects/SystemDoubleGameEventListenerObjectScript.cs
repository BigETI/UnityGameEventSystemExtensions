using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "DoubleGameEvent", menuName = "Game events/System/Game event (Double)")]
    public class SystemDoubleGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Double>, ISystemDoubleGameEventListenerObject
    {
        // ...
    }
}
