using System;
using UnityGameEvents.Controllers;
using UnityGameEventSystemExtensions.Objects;

namespace UnityGameEventSystemExtensions.Controllers
{
    public class SystemTimeSpanGameEventListenerControllerScript : AGameEventWithParameterListenerControllerScript<SystemTimeSpanGameEventListenerObjectScript, TimeSpan>, ISystemTimeSpanGameEventListenerController
    {
        // ...
    }
}
