using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CommunityToolkit.ObjectModel;

namespace XamarinMVVMDemo.Models
{
    public class UserModel : ObservableObject
    {
        public string UserID { get; set; } //변경되지 않음.
        
        public string _userName;
        public string _email;
        public string _telephone;
        public DateTime? _registDate;


        public string UserName { get => this._userName; set => SetProperty(ref this._userName, value); }

        public string Email { get => this._email; set => SetProperty(ref this._email, value); }
        public string Telephone { get => this._telephone; set => SetProperty(ref this._telephone, value); }

        public DateTime? RegistDate { get => this._registDate; set => SetProperty(ref this._registDate, value); }

    }
}
