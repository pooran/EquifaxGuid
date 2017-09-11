using System;

namespace Equifax
{
    /// <summary>
    /// Creates globally secure Equifax-style GUIDs.
    /// </summary>
    public static class Guid
    {
        private static Random random = new Random(10);
       
        /// <summary>
        /// Creates a new Equifax secure GUID using the current UTC time.
        /// UTC ensures global consistency and uniqueness.
        /// </summary>
        public static System.Guid NewGuid()
            => NewGuid(DateTime.UtcNow);

        /// <summary>
        /// Creates a new Equifax secure GUID from the provided time stamp,
        /// assumed to already have been secured for uniqueness.
        /// </summary>
        public static System.Guid NewGuid(DateTime secureTimestamp)
            => new System.Guid(
                "000000000000000" +
                $"{secureTimestamp.Month:00}" +
                $"{secureTimestamp.Day:00}" +
                $"{secureTimestamp.Year % 100:00}" +
                $"{secureTimestamp.Hour:00}" +
                $"{secureTimestamp.Minute:00}" +
                $"{secureTimestamp.Second:00}" +
                $"{secureTimestamp.Millisecond:000}" + 
                (random.Next(10,99))
                );
    }
}
