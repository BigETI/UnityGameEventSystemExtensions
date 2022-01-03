using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "ArrayGameEvent", menuName = "Game events/System/Game event (Array)")]
    public class SystemArrayGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Array>, ISystemArrayGameEventListenerObject
    {
        // ...
    }
}
