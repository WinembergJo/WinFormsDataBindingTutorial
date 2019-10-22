﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using InventoryManager.Data;

namespace InventoryManager.WinForms.ViewModels
{
    public class WorldViewModel : INotifyPropertyChanged
    {
        

        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }

        public World World { get; set; }
    }
}