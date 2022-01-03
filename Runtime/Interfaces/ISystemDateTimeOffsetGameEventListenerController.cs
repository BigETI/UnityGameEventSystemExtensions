using System;
using UnityGameEvents;
using UnityGameEventSystemExtensions.Objects;

namespace UnityGameEventSystemExtensions
{
    public interface ISystemDateTimeOffsetGameEventListenerController : IGameEventWithParameterListenerController<SystemDateTimeOffsetGameEventListenerObjectScript, DateTimeOffset>
    {
        // ...
    }
}
