using System.Collections.ObjectModel;

namespace Alrev.Intl.Abstractions
{
    public static class ReadOnlyDictionaryExtensions
    {
        public static TValue GetValueOrDefault<TKey, TValue>(this ReadOnlyDictionary<TKey, TValue> dict, TKey key)
             => dict.TryGetValue(key, out TValue value) ? value : default;
        public static TValue GetValueOrDefault<TKey, TValue>(this ReadOnlyDictionary<TKey, TValue> dict, TKey key, TValue defaultValue)
             => dict.TryGetValue(key, out TValue value) ? value : defaultValue;
    }
}
