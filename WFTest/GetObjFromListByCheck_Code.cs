﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace WFTest
{

    public sealed class GetObjFromListByCheck_Code : CodeActivity
    {
        // 定义一个字符串类型的活动输入参数
        public InArgument<string> Text { get; set; }

        public InArgument<List<PMS.Model.QueryModel.Redis_SMSContent>> List_redis { get; set; }

        public OutArgument<PMS.Model.QueryModel.Redis_SMSContent> First_Obj { get; set; }

        // 如果活动返回值，则从 CodeActivity<TResult>
        // 并从 Execute 方法返回该值。
        protected override void Execute(CodeActivityContext context)
        {
            // 获取 Text 输入参数的运行时值
            string text = context.GetValue(this.Text);
            
        }

        public void CheckTimeOut_RedisList(List<PMS.Model.QueryModel.Redis_SMSContent> list_final, double seconds_add, CodeActivityContext context)
        {
            //3 判断集合第一个对象的时间是否已经超过规定的时间
            if (list_final.Count > 0)
            {
                if (list_final.First().Dt < DateTime.Now.AddSeconds(seconds_add))
                {
                    //7月28日添加若发送人数超过一百人需要连续进行两次查询
                    var model = list_final.First();
                    context.SetValue(First_Obj, model);
                }
                else
                {
                    //ToShow("现有Redis集合中以没有时间范围内的对象");
                    //ToShow("现Redis集合中共有:" + list_final.Count());
                    return;
                }
            }
            //直到出现集合第一个对象时间已经不再超过规定时间则跳出
            else
            {
                //ToShow("现有Redis集合中以没有时间范围内的对象");
                //ToShow("现Redis集合中共有:" + list_final.Count());
                return;
            }
        }
    }
}