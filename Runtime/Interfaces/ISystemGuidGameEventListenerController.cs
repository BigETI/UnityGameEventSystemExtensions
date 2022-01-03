using System;
using UnityGameEvents;
using UnityGameEventSystemExtensions.Objects;

namespace UnityGameEventSystemExtensions
{
    public interface ISystemGuidGameEventListenerController : IGameEventWithParameterListenerController<SystemGuidGameEventListenerObjectScript, Guid>
    {
        // ...
    }
}
