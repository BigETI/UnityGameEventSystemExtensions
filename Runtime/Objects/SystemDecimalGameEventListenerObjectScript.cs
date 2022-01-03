using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "DecimalGameEvent", menuName = "Game events/System/Game event (Decimal)")]
    public class SystemDecimalGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Decimal>, ISystemDecimalGameEventListenerObject
    {
        // ...
    }
}
