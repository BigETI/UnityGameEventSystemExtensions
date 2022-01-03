using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "UriGameEvent", menuName = "Game events/System/Game event (Uri)")]
    public class SystemUriGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Uri>, ISystemUriGameEventListenerObject
    {
        // ...
    }
}
