﻿using System;
using System.Threading;
using FacebookApp.Models;
using FacebookWrapper;

namespace FacebookApp.Facades
{
    public class UserProfileFacade
    {
        private readonly UserProfile r_UserProfile;
        public event Action UserProfileUpdated;

        public LoginResult LoginResult { get; private set; }

        public UserProfileFacade()
        {
            r_UserProfile = new UserProfile();
        }

        public void GetUserProfile()
        {
            new Thread(
                () =>
                    {
                        LoginResult = r_UserProfile.GetUserProfile();
                        UserProfileUpdated?.Invoke();
                    }).Start();
        }
    }
}