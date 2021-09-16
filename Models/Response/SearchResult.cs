#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.PokeApi.Models.Response
{
    /// <summary>
    /// response object for return out of the API
    /// </summary>
    public class SearchResult<T>
    {
        /// <summary>
        /// count of items being returned
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// string containing data for next in pagination
        /// </summary>
        public string? Next { get; set; }

        /// <summary>
        /// string containing data for previous in pagination
        /// </summary>
        public string? Previous { get; set; }

        /// <summary>
        /// list of result objects being returned
        /// </summary>
        public IList<T> Results { get; set; } = null!;
    }
}
