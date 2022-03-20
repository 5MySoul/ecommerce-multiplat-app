using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysDbChangelog
    {
        public string ScriptName { get; set; } = null!;
        public DateTime? CreateTs { get; set; }
        public int? IsInit { get; set; }
    }
}
