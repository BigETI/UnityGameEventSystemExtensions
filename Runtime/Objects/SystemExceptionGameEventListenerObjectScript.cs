using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "ExceptionGameEvent", menuName = "Game events/System/Game event (Exception)")]
    public class SystemExceptionGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Exception>, ISystemExceptionGameEventListenerObject
    {
        // ...
    }
}
