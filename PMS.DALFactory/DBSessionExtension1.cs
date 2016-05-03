﻿
using PMS.IDAL;

namespace PMS.DALFactory
{
public partial class DBSession
    {
	#region _ActionInfoDAL 属性 
	private IDAL.IActionInfoDAL _ActionInfoDAL;
	#endregion

	#region
        /// <summary>
        /// 获取ActionInfoDAL的实例
        /// </summary>
        public IActionInfoDAL ActionInfoDAL
        {
            get
            {
                if(_ActionInfoDAL==null)
                {
                    _ActionInfoDAL = AbstractFactory.CreateActionInfoDAL();
                }
                return _ActionInfoDAL;
            }

            set
            {
                _ActionInfoDAL = value;
            }
        }
	#endregion
	

		#region _P_DepartmentInfoDAL 属性 
	private IDAL.IP_DepartmentInfoDAL _P_DepartmentInfoDAL;
	#endregion

	#region
        /// <summary>
        /// 获取P_DepartmentInfoDAL的实例
        /// </summary>
        public IP_DepartmentInfoDAL P_DepartmentInfoDAL
        {
            get
            {
                if(_P_DepartmentInfoDAL==null)
                {
                    _P_DepartmentInfoDAL = AbstractFactory.CreateP_DepartmentInfoDAL();
                }
                return _P_DepartmentInfoDAL;
            }

            set
            {
                _P_DepartmentInfoDAL = value;
            }
        }
	#endregion
	

		#region _P_GroupDAL 属性 
	private IDAL.IP_GroupDAL _P_GroupDAL;
	#endregion

	#region
        /// <summary>
        /// 获取P_GroupDAL的实例
        /// </summary>
        public IP_GroupDAL P_GroupDAL
        {
            get
            {
                if(_P_GroupDAL==null)
                {
                    _P_GroupDAL = AbstractFactory.CreateP_GroupDAL();
                }
                return _P_GroupDAL;
            }

            set
            {
                _P_GroupDAL = value;
            }
        }
	#endregion
	

		#region _P_PersonInfoDAL 属性 
	private IDAL.IP_PersonInfoDAL _P_PersonInfoDAL;
	#endregion

	#region
        /// <summary>
        /// 获取P_PersonInfoDAL的实例
        /// </summary>
        public IP_PersonInfoDAL P_PersonInfoDAL
        {
            get
            {
                if(_P_PersonInfoDAL==null)
                {
                    _P_PersonInfoDAL = AbstractFactory.CreateP_PersonInfoDAL();
                }
                return _P_PersonInfoDAL;
            }

            set
            {
                _P_PersonInfoDAL = value;
            }
        }
	#endregion
	

		#region _R_Department_MissionDAL 属性 
	private IDAL.IR_Department_MissionDAL _R_Department_MissionDAL;
	#endregion

	#region
        /// <summary>
        /// 获取R_Department_MissionDAL的实例
        /// </summary>
        public IR_Department_MissionDAL R_Department_MissionDAL
        {
            get
            {
                if(_R_Department_MissionDAL==null)
                {
                    _R_Department_MissionDAL = AbstractFactory.CreateR_Department_MissionDAL();
                }
                return _R_Department_MissionDAL;
            }

            set
            {
                _R_Department_MissionDAL = value;
            }
        }
	#endregion
	

		#region _R_Group_MissionDAL 属性 
	private IDAL.IR_Group_MissionDAL _R_Group_MissionDAL;
	#endregion

	#region
        /// <summary>
        /// 获取R_Group_MissionDAL的实例
        /// </summary>
        public IR_Group_MissionDAL R_Group_MissionDAL
        {
            get
            {
                if(_R_Group_MissionDAL==null)
                {
                    _R_Group_MissionDAL = AbstractFactory.CreateR_Group_MissionDAL();
                }
                return _R_Group_MissionDAL;
            }

            set
            {
                _R_Group_MissionDAL = value;
            }
        }
	#endregion
	

		#region _R_UserInfo_ActionInfoDAL 属性 
	private IDAL.IR_UserInfo_ActionInfoDAL _R_UserInfo_ActionInfoDAL;
	#endregion

	#region
        /// <summary>
        /// 获取R_UserInfo_ActionInfoDAL的实例
        /// </summary>
        public IR_UserInfo_ActionInfoDAL R_UserInfo_ActionInfoDAL
        {
            get
            {
                if(_R_UserInfo_ActionInfoDAL==null)
                {
                    _R_UserInfo_ActionInfoDAL = AbstractFactory.CreateR_UserInfo_ActionInfoDAL();
                }
                return _R_UserInfo_ActionInfoDAL;
            }

            set
            {
                _R_UserInfo_ActionInfoDAL = value;
            }
        }
	#endregion
	

		#region _R_UserInfo_DepartmentInfoDAL 属性 
	private IDAL.IR_UserInfo_DepartmentInfoDAL _R_UserInfo_DepartmentInfoDAL;
	#endregion

	#region
        /// <summary>
        /// 获取R_UserInfo_DepartmentInfoDAL的实例
        /// </summary>
        public IR_UserInfo_DepartmentInfoDAL R_UserInfo_DepartmentInfoDAL
        {
            get
            {
                if(_R_UserInfo_DepartmentInfoDAL==null)
                {
                    _R_UserInfo_DepartmentInfoDAL = AbstractFactory.CreateR_UserInfo_DepartmentInfoDAL();
                }
                return _R_UserInfo_DepartmentInfoDAL;
            }

            set
            {
                _R_UserInfo_DepartmentInfoDAL = value;
            }
        }
	#endregion
	

		#region _R_UserInfo_GroupDAL 属性 
	private IDAL.IR_UserInfo_GroupDAL _R_UserInfo_GroupDAL;
	#endregion

	#region
        /// <summary>
        /// 获取R_UserInfo_GroupDAL的实例
        /// </summary>
        public IR_UserInfo_GroupDAL R_UserInfo_GroupDAL
        {
            get
            {
                if(_R_UserInfo_GroupDAL==null)
                {
                    _R_UserInfo_GroupDAL = AbstractFactory.CreateR_UserInfo_GroupDAL();
                }
                return _R_UserInfo_GroupDAL;
            }

            set
            {
                _R_UserInfo_GroupDAL = value;
            }
        }
	#endregion
	

		#region _R_UserInfo_PersonInfoDAL 属性 
	private IDAL.IR_UserInfo_PersonInfoDAL _R_UserInfo_PersonInfoDAL;
	#endregion

	#region
        /// <summary>
        /// 获取R_UserInfo_PersonInfoDAL的实例
        /// </summary>
        public IR_UserInfo_PersonInfoDAL R_UserInfo_PersonInfoDAL
        {
            get
            {
                if(_R_UserInfo_PersonInfoDAL==null)
                {
                    _R_UserInfo_PersonInfoDAL = AbstractFactory.CreateR_UserInfo_PersonInfoDAL();
                }
                return _R_UserInfo_PersonInfoDAL;
            }

            set
            {
                _R_UserInfo_PersonInfoDAL = value;
            }
        }
	#endregion
	

		#region _R_UserInfo_SMSMissionDAL 属性 
	private IDAL.IR_UserInfo_SMSMissionDAL _R_UserInfo_SMSMissionDAL;
	#endregion

	#region
        /// <summary>
        /// 获取R_UserInfo_SMSMissionDAL的实例
        /// </summary>
        public IR_UserInfo_SMSMissionDAL R_UserInfo_SMSMissionDAL
        {
            get
            {
                if(_R_UserInfo_SMSMissionDAL==null)
                {
                    _R_UserInfo_SMSMissionDAL = AbstractFactory.CreateR_UserInfo_SMSMissionDAL();
                }
                return _R_UserInfo_SMSMissionDAL;
            }

            set
            {
                _R_UserInfo_SMSMissionDAL = value;
            }
        }
	#endregion
	

		#region _RoleInfoDAL 属性 
	private IDAL.IRoleInfoDAL _RoleInfoDAL;
	#endregion

	#region
        /// <summary>
        /// 获取RoleInfoDAL的实例
        /// </summary>
        public IRoleInfoDAL RoleInfoDAL
        {
            get
            {
                if(_RoleInfoDAL==null)
                {
                    _RoleInfoDAL = AbstractFactory.CreateRoleInfoDAL();
                }
                return _RoleInfoDAL;
            }

            set
            {
                _RoleInfoDAL = value;
            }
        }
	#endregion
	

		#region _S_SMSContentDAL 属性 
	private IDAL.IS_SMSContentDAL _S_SMSContentDAL;
	#endregion

	#region
        /// <summary>
        /// 获取S_SMSContentDAL的实例
        /// </summary>
        public IS_SMSContentDAL S_SMSContentDAL
        {
            get
            {
                if(_S_SMSContentDAL==null)
                {
                    _S_SMSContentDAL = AbstractFactory.CreateS_SMSContentDAL();
                }
                return _S_SMSContentDAL;
            }

            set
            {
                _S_SMSContentDAL = value;
            }
        }
	#endregion
	

		#region _S_SMSMissionDAL 属性 
	private IDAL.IS_SMSMissionDAL _S_SMSMissionDAL;
	#endregion

	#region
        /// <summary>
        /// 获取S_SMSMissionDAL的实例
        /// </summary>
        public IS_SMSMissionDAL S_SMSMissionDAL
        {
            get
            {
                if(_S_SMSMissionDAL==null)
                {
                    _S_SMSMissionDAL = AbstractFactory.CreateS_SMSMissionDAL();
                }
                return _S_SMSMissionDAL;
            }

            set
            {
                _S_SMSMissionDAL = value;
            }
        }
	#endregion
	

		#region _S_SMSRecord_CurrentDAL 属性 
	private IDAL.IS_SMSRecord_CurrentDAL _S_SMSRecord_CurrentDAL;
	#endregion

	#region
        /// <summary>
        /// 获取S_SMSRecord_CurrentDAL的实例
        /// </summary>
        public IS_SMSRecord_CurrentDAL S_SMSRecord_CurrentDAL
        {
            get
            {
                if(_S_SMSRecord_CurrentDAL==null)
                {
                    _S_SMSRecord_CurrentDAL = AbstractFactory.CreateS_SMSRecord_CurrentDAL();
                }
                return _S_SMSRecord_CurrentDAL;
            }

            set
            {
                _S_SMSRecord_CurrentDAL = value;
            }
        }
	#endregion
	

		#region _S_SMSRecord_HistoryDAL 属性 
	private IDAL.IS_SMSRecord_HistoryDAL _S_SMSRecord_HistoryDAL;
	#endregion

	#region
        /// <summary>
        /// 获取S_SMSRecord_HistoryDAL的实例
        /// </summary>
        public IS_SMSRecord_HistoryDAL S_SMSRecord_HistoryDAL
        {
            get
            {
                if(_S_SMSRecord_HistoryDAL==null)
                {
                    _S_SMSRecord_HistoryDAL = AbstractFactory.CreateS_SMSRecord_HistoryDAL();
                }
                return _S_SMSRecord_HistoryDAL;
            }

            set
            {
                _S_SMSRecord_HistoryDAL = value;
            }
        }
	#endregion
	

		#region _UserInfoDAL 属性 
	private IDAL.IUserInfoDAL _UserInfoDAL;
	#endregion

	#region
        /// <summary>
        /// 获取UserInfoDAL的实例
        /// </summary>
        public IUserInfoDAL UserInfoDAL
        {
            get
            {
                if(_UserInfoDAL==null)
                {
                    _UserInfoDAL = AbstractFactory.CreateUserInfoDAL();
                }
                return _UserInfoDAL;
            }

            set
            {
                _UserInfoDAL = value;
            }
        }
	#endregion
	

		}
}