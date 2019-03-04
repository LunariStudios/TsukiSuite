using UnityEngine;

namespace Lunari.Tsuki {
    /// <summary>
    /// Utility class for getting random values.
    /// <br/>
    /// <b>This class is not thread safe, but preferred when used in a sync context</b>, due to using Unity's internal
    /// randomization algorithms.
    /// </summary>
    public static class Randomization {
        /// <summary>
        /// Returns either true or false. 50% chance each.
        /// <br/>
        /// <b>NOT THREAD-SAFE.</b> Unity will yell at you if you use this outside of the main thread.
        /// <br/>
        /// For an async version of <see cref="Randomization"/> refer to <see cref="RandomizationAsync"/>.  
        /// <seealso cref="RandomizationAsync.NextBool"/>
        /// </summary>
        public static bool NextBool() {
            return Random.value > 0.5;
        }

        /// <summary>
        /// Generates a random floating point number between 0 and 1 and multiplies it by <see cref="multiplier"/>,
        /// returning the result. 
        /// <br/>
        /// <b>NOT THREAD-SAFE.</b> Unity will yell at you if you use this outside of the main thread.
        /// <br/>
        /// For an async version of <see cref="Randomization"/> refer to <see cref="RandomizationAsync"/>.
        /// 
        /// <seealso cref="RandomizationAsync.NextFloat"/>
        /// </summary>
        public static float NextFloat(float multiplier = 1F) {
            return Random.value * multiplier;
        }
    }

    /// <summary>
    /// Utility class for getting random values.
    /// <br/>
    /// <b>This class is thread safe</b>, meaning you can use it outside of the main thread.
    /// But you shouldn't use it 100% of the time. <b>When in a sync context, <see cref="Randomization"/> is preferred</b>, due
    /// to using Unity's internal randomization algorithms.
    /// </summary>
    public static class RandomizationAsync {
        /// <summary>
        /// This exists because Unity doesn't like us accessing <see cref="Random"/>.<see cref="Random.value"/> outside
        /// of the main thread. So we use Mono's random. 
        /// </summary>
        private static readonly System.Random systemRandom = new System.Random();

        /// <summary>
        /// Returns either true or false. 50% chance each.
        /// <br/>
        /// If used in a sync context, <see cref="Randomization"/>.<see cref="Randomization.NextBool"/> is preferred.  
        /// <seealso cref="Randomization.NextBool"/>
        /// </summary>
        public static bool NextBool() {
            return systemRandom.NextDouble() > 0.5;
        }

        /// <summary>
        /// Generates a random floating point number between 0 and 1 and multiplies it by <see cref="multiplier"/>,
        /// returning the result.
        /// <br/>
        /// If used in a sync context, <see cref="Randomization"/>.<see cref="Randomization.NextFloat"/> is preferred.
        /// <seealso cref="Randomization.NextFloat"/>
        /// </summary>
        public static float NextFloat(float multiplier = 1F) {
            return (float) systemRandom.NextDouble() * multiplier;
        }
    }
}