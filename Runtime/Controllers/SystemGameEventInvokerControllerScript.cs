using System;
using UnityGameEvents.Controllers;

/// <summary>
/// Unity game events "System" extensions controllers namespace
/// </summary>
namespace UnityGameEventSystemExtensions.Controllers
{
    /// <summary>
    /// A class that describes a "System" game event invoker controller script
    /// </summary>
    public class SystemGameEventInvokerControllerScript : GameEventInvokerControllerScript, ISystemGameEventInvokerController
    {
        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(bool value) => Invoke<bool>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(byte value) => Invoke<byte>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(sbyte value) => Invoke<sbyte>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(short value) => Invoke<short>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(ushort value) => Invoke<ushort>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(int value) => Invoke<int>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(uint value) => Invoke<uint>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(long value) => Invoke<long>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(ulong value) => Invoke<ulong>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(float value) => Invoke<float>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(double value) => Invoke<double>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(decimal value) => Invoke<decimal>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(object value) => Invoke<object>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(char value) => Invoke<char>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(string value) => Invoke<string>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(FormattableString value) => Invoke<FormattableString>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Uri value) => Invoke<Uri>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Attribute value) => Invoke<Attribute>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Exception value) => Invoke<Exception>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Type value) => Invoke<Type>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Array value) => Invoke<Array>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Enum value) => Invoke<Enum>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Delegate value) => Invoke<Delegate>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Guid value) => Invoke<Guid>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(DateTime value) => Invoke<DateTime>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(DateTimeOffset value) => Invoke<DateTimeOffset>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(TimeSpan value) => Invoke<TimeSpan>(value);
    }
}
