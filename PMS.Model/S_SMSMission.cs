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
    
    public partial class S_SMSMission
    {
        public S_SMSMission()
        {
            this.R_Department_Mission = new HashSet<R_Department_Mission>();
            this.R_Group_Mission = new HashSet<R_Group_Mission>();
            this.R_UserInfo_SMSMission = new HashSet<R_UserInfo_SMSMission>();
            this.S_SMSRecord_History = new HashSet<S_SMSRecord_History>();
            this.S_SMSMsgContent = new HashSet<S_SMSMsgContent>();
        }
    
        public int SMID { get; set; }
        public string SMSMissionName { get; set; }
        public System.DateTime SubTime { get; set; }
        public System.DateTime ModifiedOnTime { get; set; }
        public string Remark { get; set; }
        public bool isDel { get; set; }
        public bool isMMS { get; set; }
        public int Sort { get; set; }
    
        public virtual ICollection<R_Department_Mission> R_Department_Mission { get; set; }
        public virtual ICollection<R_Group_Mission> R_Group_Mission { get; set; }
        public virtual ICollection<R_UserInfo_SMSMission> R_UserInfo_SMSMission { get; set; }
        public virtual ICollection<S_SMSRecord_History> S_SMSRecord_History { get; set; }
        public virtual ICollection<S_SMSMsgContent> S_SMSMsgContent { get; set; }
    }
}
