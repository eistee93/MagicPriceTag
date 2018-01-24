using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFUI.MVVM;
using MKM;
using PriceTagData;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace WPFUI
{
   class MainViewModel : INotifyPropertyChanged
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

      private APICredentials credentials;
      public APICredentials Credentials
      {
         get
         {
            return credentials;
         }
         set
         {
            NotifyPropertyChanged(ref credentials, value);
         }
      }

      private string result;
      public string Result
      {
         get
         {
            return result;
         }
         set
         {
            NotifyPropertyChanged(ref result, value);
         }
      }

      public ICommand DoStuffCommand
      {
         get
         {
            return new DelegateCommand(DoStuff);
         }
      }

      public MainViewModel()
      {
         Credentials = new APICredentials();
      }

      public void DoStuff()
      {
         RequestHelper helper = new RequestHelper();
         XmlDocument xdoc = helper.OrderRequest(Credentials, (int)OrderActor.Buyer, (int)OrderState.Received);
         response rep = Serialization.SerializeOrder(xdoc);
         Result = xdoc.OuterXml;
      }
   }
}
