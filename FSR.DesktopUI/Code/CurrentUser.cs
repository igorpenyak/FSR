﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSR.Entities;

namespace FSR.DesktopUI.Code
{
    public static class CurrentUser
    {
        #region Methods
        public static void Initialize(User user)
        {
            if (_currentUser != null)
            {
                throw new InvalidOperationException("Current user has already been specified");
            }
            _currentUser = user;
        }

        #endregion

        #region Properties

        public static int Id
        {
            get
            {
                return _currentUser.Id;
            }
        }

        public static string Name
        {
            get
            {
                return _currentUser.Name;
            }
        }

        public static string Surname
        {
            get
            {
                return _currentUser.Surname;
            }
        }

        public static string Login
        {
            get
            {
                return _currentUser.Login;
            }
        }

        #endregion

        #region Private Fields

        private static User _currentUser;

        #endregion
    }
}
