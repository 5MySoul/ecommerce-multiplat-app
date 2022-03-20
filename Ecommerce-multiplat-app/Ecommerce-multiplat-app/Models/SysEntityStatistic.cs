using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysEntityStatistic
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Name { get; set; }
        public long? InstanceCount { get; set; }
        public int? FetchUi { get; set; }
        public int? MaxFetchUi { get; set; }
        public int? LazyCollectionThreshold { get; set; }
        public int? LookupScreenThreshold { get; set; }
    }
}
