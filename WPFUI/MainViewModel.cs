using System.Windows.Input;
using WPFUI.MVVM;
using MKM;
using PriceTagData;
using PriceTagData.Response;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml;

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
         OrderResponse rep = Deserialization.DeserializeOrderResponse(xdoc);
         Result = xdoc.OuterXml;
      }
   }
}
