﻿using MoneyFox.Business.ViewModels.Interfaces;
using MoneyFox.DataAccess.Entities;
using MoneyFox.DataAccess.Pocos;
using MoneyFox.Foundation.Groups;
using MvvmCross.Commands;
using MvvmCross.Localization;
using MvvmCross.ViewModels;

namespace MoneyFox.Business.ViewModels.DesignTime
{
    public class DesignTimeAccountListViewModel : BaseViewModel, IAccountListViewModel
    {
        public MvxObservableCollection<AlphaGroupListGroup<AccountViewModel>> Accounts => new MvxObservableCollection<AlphaGroupListGroup<AccountViewModel>>
        {
            new AlphaGroupListGroup<AccountViewModel>("Included")
            {
                new AccountViewModel(new Account{Data = new AccountEntity{Name =  "Income", CurrentBalance = 1234}})
            },
            new AlphaGroupListGroup<AccountViewModel>("Excluded")
            {
                new AccountViewModel(new Account{Data = new AccountEntity{Name =  "Savings", CurrentBalance = 4325}})
            }
        };

        public bool HasNoAccounts { get; } = true;
        public IBalanceViewModel BalanceViewModel { get; }
        public IAccountListViewActionViewModel ViewActionViewModel { get; }
        public MvxAsyncCommand<AccountViewModel> OpenOverviewCommand { get; }
        public MvxAsyncCommand<AccountViewModel> EditAccountCommand { get; }
        public MvxAsyncCommand<AccountViewModel> DeleteAccountCommand { get; }
        public MvxAsyncCommand GoToAddAccountCommand { get; }
    }
}
