﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TeamHamsterBank
{
    abstract class User
    {
        private string _userId;
        private string _passWord;

        public static bool CheckUserName(List<User> users, string inputId)
        {
            return users.Exists(u => u._userId == inputId);
        }
        public static bool CheckPassWord(List<User> users, string inputId, string inputPassWord)
        {
            var user = users.Find(u => u._userId == inputId);
            if (user._passWord == inputPassWord)
                return true;
            else
                return false;
        }
    }
}