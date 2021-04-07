using System;
using System.Collections.ObjectModel;

namespace Alrev.Intl.Abstractions
{
    /// <summary>
    /// Provides extension methods for ReadOnlyDictionary.
    /// </summary>
    /// <remarks>
    /// Only used by netstandard2.0
    /// </remarks>
    public static class ReadOnlyDictionaryExtensions
    {
        /// <summary>
        /// Tries to get the value associated with the specified key in the dictionary
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary</typeparam>
        /// <param name="dict">A dictionary with keys of type TKey and values of type TValue</param>
        /// <param name="key">The key of the value to get</param>
        /// <param name="defaultValue">The default value to return when the dictionary cannot find a value associated with the specified key</param>
        /// <returns>A TValue instance. When the method is successful, the returned object is the value associated with the specified key. When the method fails, it returns defaultValue</returns>
        /// <exception cref="ArgumentNullException">dictionary is null</exception>
        public static TValue GetValueOrDefault<TKey, TValue>(this ReadOnlyDictionary<TKey, TValue> dict, TKey key, TValue defaultValue)
             => dict.TryGetValue(key, out TValue value) ? value : defaultValue;
    }
}
