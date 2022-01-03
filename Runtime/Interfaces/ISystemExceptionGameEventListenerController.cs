using System;
using UnityGameEvents;
using UnityGameEventSystemExtensions.Objects;

namespace UnityGameEventSystemExtensions
{
    public interface ISystemExceptionGameEventListenerController : IGameEventWithParameterListenerController<SystemExceptionGameEventListenerObjectScript, Exception>
    {
        // ...
    }
}
