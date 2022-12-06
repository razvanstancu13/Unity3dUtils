using System.Collections.Generic;
using UnityEngine;

namespace ExtensionMethods
{
    public static class Vector2Extensions
    {
        public static Vector4 Swizzle(this Vector2 v, string pattern)
        {
            var mapping = new Dictionary<char, float>
            {
                { 'x', v.x },
                { 'y', v.y },
                { '0', 0f },
                { '1', 1f }
            };

            var length = Mathf.Min(4f, pattern.Length);
            var result = Vector4.zero;
            for (int i = 0; i < length; ++i)
            {
                if (mapping.ContainsKey(pattern[i]))
                {
                    result[i] = mapping[pattern[i]];
                }
            }

            return result;
        }
    }

    public static class Vector3Extensions
    {
        public static Vector4 Swizzle(this Vector3 v, string pattern)
        {
            var mapping = new Dictionary<char, float>
            {
                { 'x', v.x },
                { 'y', v.y },
                { 'z', v.z },
                { '0', 0f },
                { '1', 1f }
            };

            var length = Mathf.Min(4f, pattern.Length);
            var result = Vector4.zero;
            for (int i = 0; i < length; ++i)
            {
                if (mapping.ContainsKey(pattern[i]))
                {
                    result[i] = mapping[pattern[i]];
                }
            }

            return result;
        }
    }

    public static class Vector4Extensions
    {
        public static Vector4 Swizzle(this Vector4 v, string pattern)
        {
            var mapping = new Dictionary<char, float>
            {
                { 'x', v.x },
                { 'y', v.y },
                { 'z', v.z },
                { 'w', v.w },
                { '0', 0f },
                { '1', 1f }
            };

            var length = Mathf.Min(4f, pattern.Length);
            var result = Vector4.zero;
            for (int i = 0; i < length; ++i)
            {
                if (mapping.ContainsKey(pattern[i]))
                {
                    result[i] = mapping[pattern[i]];
                }
            }

            return result;
        }
    }
}