//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class P_DepartmentInfo
    {
        public P_DepartmentInfo()
        {
            this.R_Department_Mission = new HashSet<R_Department_Mission>();
            this.P_PersonInfo = new HashSet<P_PersonInfo>();
        }
    
        public int DID { get; set; }
        public int PDID { get; set; }
        public string DepartmentName { get; set; }
        public int Area { get; set; }
        public bool isDel { get; set; }
        public string Remark { get; set; }
    
        public virtual ICollection<R_Department_Mission> R_Department_Mission { get; set; }
        public virtual ICollection<P_PersonInfo> P_PersonInfo { get; set; }
    }
}