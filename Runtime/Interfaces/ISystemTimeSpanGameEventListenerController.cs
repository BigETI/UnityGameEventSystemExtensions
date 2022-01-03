using System;
using UnityGameEvents;
using UnityGameEventSystemExtensions.Objects;

namespace UnityGameEventSystemExtensions
{
    public interface ISystemTimeSpanGameEventListenerController : IGameEventWithParameterListenerController<SystemTimeSpanGameEventListenerObjectScript, TimeSpan>
    {
        // ...
    }
}
