//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AUSUMediaSite.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbMediaInfo
    {
        public tbMediaInfo()
        {
            this.tbEqMediaInfo = new HashSet<tbEqMediaInfo>();
        }
    
        public int ID { get; set; }
        public string MediaName { get; set; }
        public string MediaUrl { get; set; }
        public string SubTitle { get; set; }
        public Nullable<long> MediaSize { get; set; }
        public string MediaType { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
    
        public virtual ICollection<tbEqMediaInfo> tbEqMediaInfo { get; set; }
    }
}