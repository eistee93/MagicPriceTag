using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MKM
{
   public class APICredentials: INotifyPropertyChanged
   {
      #region "INPC"
      public event PropertyChangedEventHandler PropertyChanged;

      public void NotifyPropertyChanged([CallerMemberName] string memberName = null)
      {
         if (PropertyChanged != null)
         {
            PropertyChanged(this, new PropertyChangedEventArgs(memberName));
         }
      }

      public void NotifyPropertyChanged<T>(ref T fieldValue, T value, [CallerMemberName] string memberName = null)
      {
         fieldValue = value;

         if (PropertyChanged != null)
         {
            PropertyChanged(this, new PropertyChangedEventArgs(memberName));
         }
      }
      #endregion

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

   }
}
