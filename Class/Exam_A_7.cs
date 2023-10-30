using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPS_Logical_and_Review_Code.Class
{
	class Cache
	{
		private static Dictionary<int, CachedItem> _cache = new Dictionary<int, CachedItem>();
		public static void Add(int key, object value, TimeSpan lifespan)
		{
			_cache.Add(key, new CachedItem { Value = value, Expiration = DateTime.Now + lifespan });
		}

		public static object? Get(int key)
		{
			if (!_cache.ContainsKey(key))
			{
				return null;
			}

			CachedItem item = _cache[key];

			if (item.Expiration < DateTime.Now)
			{
				_cache.Remove(key);
				return null;
			}
			return item.Value;
		}

		private sealed class CachedItem
		{
			public object Value { get; set; }
			public DateTime Expiration { get; set; }
		}

	}
}
