﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MKMAPI;
using PriceTagUI.MVVM;

namespace PriceTagUI.ViewModel
{
   class MainViewModel : MVVM.INotifyPropertyChangedBase
   {
        private string appToken;
        public string AppToken
        {
            get
            {
                return appToken;
            }
            set
            {
                NotifyPropertyChanged(ref appToken, value);
            }
        }

        private string appSecret;
        public string AppSecret
        {
            get
            {
                return appSecret;
            }
            set
            {
                NotifyPropertyChanged(ref appSecret, value);
            }
        }

        private string accessToken;
        public string AccessToken
        {
            get
            {
                return accessToken;
            }
            set
            {
                NotifyPropertyChanged(ref accessToken, value);
            }
        }

        private string accessSecret;
        public string AccessSecret
        {
            get
            {
                return accessSecret;
            }
            set
            {
                NotifyPropertyChanged(ref accessSecret, value);
            }
        }

        public ICommand DoStuffCommand
        {
            get
            {
                return new DelegateCommand(DoStuff);
            }
        }

        public void DoStuff()
        {
            RequestHelper helper = null;
        }
    }
}
