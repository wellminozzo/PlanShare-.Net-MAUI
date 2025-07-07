﻿using CommunityToolkit.Mvvm.Input;
using PlanShare.App.Navigation;

namespace PlanShare.App.ViewModels.Pages.OnBoarding;

public partial class OnBoardingViewModel
{


    [RelayCommand]
    public async Task LoginWihtEmailAndPassword() => await Shell.Current.GoToAsync(RoutePages.LOGIN_PAGE);
    

    [RelayCommand]
    public void LoginWithGoogle()
    {
        
    }

    [RelayCommand]
    public async Task RegisterUserAccount() => await Shell.Current.GoToAsync(RoutePages.USER_REGISTER_ACCOUNT_PAGE);
}
