using System;
using UnityGameEvents;

/// <summary>
/// Unity game events "System" extensions namespace
/// </summary>
namespace UnityGameEventSystemExtensions
{
    /// <summary>
    /// An interface that represents a "System" game event name invoker controller
    /// </summary>
    public interface ISystemGameEventNameInvokerController : IGameEventNameInvokerController
    {
        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(bool value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(byte value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(sbyte value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(short value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(ushort value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(int value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(uint value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(long value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(ulong value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(float value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(double value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(decimal value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(object value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(char value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(string value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(FormattableString value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(Uri value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(Attribute value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(Exception value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(Type value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(Array value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(Enum value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(Delegate value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(Guid value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(DateTime value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(DateTimeOffset value);

        /// <summary>
        /// Invokes this named game event
        /// </summary>
        /// <param name="value">Named game event parameter value</param>
        void Invoke(TimeSpan value);
    }
}
