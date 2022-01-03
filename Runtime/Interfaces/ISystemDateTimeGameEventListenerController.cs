using System;
using UnityGameEvents;
using UnityGameEventSystemExtensions.Objects;

namespace UnityGameEventSystemExtensions
{
    public interface ISystemDateTimeGameEventListenerController : IGameEventWithParameterListenerController<SystemDateTimeGameEventListenerObjectScript, DateTime>
    {
        // ...
    }
}
