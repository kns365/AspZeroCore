﻿using System.ComponentModel;
using Abp.AutoMapper;
using kns.TourLand.Authorization.Users.Dto;
using Xamarin.Forms;

namespace kns.TourLand.Models.Users
{
    [AutoMapFrom(typeof(UserListDto))]
    public class UserListModel : UserListDto, INotifyPropertyChanged
    {
        private ImageSource _photo;

        public string FullName => Name + " " + Surname;

        public ImageSource Photo
        {
            get => _photo;
            set
            {
                _photo = value;
                RaisePropertyChanged(nameof(Photo));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}