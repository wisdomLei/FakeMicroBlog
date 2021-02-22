using IPS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPS.Service {
    public interface IAccountService {

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="isValid">Model验证结果</param>
        /// <param name="register">传入的RegisterModel<see cref="IPS.Models.Register"/></param>
        /// <returns></returns>
        ReturnModel AddCustomer(bool isValid,Register register);
    }
}
