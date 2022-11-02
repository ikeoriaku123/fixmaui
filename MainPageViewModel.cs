using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiUX
{
    // MainPageViewModel
    public class MainPageViewModel: INotifyPropertyChanged
    {
        private ICommand _navigateToRegisterCommand;
        private ICommand _loginCommand;
        private ICommand _getAuthenticatedCommand;
        private ICommand _logoutCommand;
        private ICommand _loadUserCommand;
        private ICommand _resetPasswordCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        string _url;
        public string Url
        {
            get
            {
                return _url;
            }
            set
            {
                _url = value;
                RaisePropertyChanged(Url);
            }
        }

        private bool _loggedIn;
        public bool LoggedIn
        {
            get
            {
                return _loggedIn;
            }
            set
            {
                _loggedIn = value;
                RaisePropertyChanged(nameof(LoggedIn));
            }
        }

        private string _userName;
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                RaisePropertyChanged(nameof(UserName));
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                RaisePropertyChanged(nameof(Password));
            }
        }

        public ICommand NavigateToRegisterCommand
        {
            get { return this._navigateToRegisterCommand; }
        }

        public ICommand LoginCommand
        {
            get { return this._loginCommand; }
        }

        public ICommand LogoutCommand
        {
            get { return this._logoutCommand; }
        }

        public ICommand GetAuthenticatedCommand
        {
            get { return this._getAuthenticatedCommand; }
        }

        public ICommand LoadUserCommand
        {
            get { return this._loadUserCommand; }
        }

        public ICommand ResetPasswordCommand
        {
            get { return this._resetPasswordCommand; }
        }

        public ICommand GetUserLocationCommand { get; private set; }

        public MainPageViewModel()
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            this._navigateToRegisterCommand = new Command(async () => await NavigateToSignupPage());
            this._loginCommand = new Command(async () => await RequestLogin());
            this._loadUserCommand = new Command(async () => await LoadUserDataAsync());
            this._resetPasswordCommand = new Command(async () => await GotoResetPasswordLink());
        }

        private async Task<bool> LoadUserDataAsync()
        {
            await Task.Yield();
            var retVal = false;

                return retVal;
        }

        private async Task RequestLogin()
        {
            await Application.Current.MainPage.DisplayAlert("Login", "Request Login", "Ok");
        }

        private async Task NavigateToSignupPage()
        {
            await Application.Current.MainPage.DisplayAlert("Login", "Sign up", "Ok");
        }

        private async Task GotoResetPasswordLink()
        {
            await Application.Current.MainPage.DisplayAlert("Login", "Reset Password", "Ok");
        }
    }
}

