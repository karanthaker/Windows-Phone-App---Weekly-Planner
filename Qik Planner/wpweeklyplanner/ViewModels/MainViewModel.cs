﻿/*
Karan Thaker
karan.thaker@hotmail.com
 */

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO.IsolatedStorage;
using System.Runtime.Serialization;

namespace wpweeklyplanner
{
    /// <summary>
    /// Main model class of the application
    /// </summary>
    public class MainViewModel : INotifyPropertyChanged
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public MainViewModel()
        {
            this.Items = new ObservableCollection<EventViewModel>();
        }

        /// <summary>
        /// Property for collection of stored events
        /// </summary>
        public ObservableCollection<EventViewModel> Items { get; private set; }

        /// <summary>
        /// Property is true if application data has been loaded, otherwise false
        /// </summary>
        public bool IsDataLoaded { get; private set; }

        /// <summary>
        /// Method for loading application data
        /// </summary>
        public void LoadData()
        {
            LoadItems();
            this.IsDataLoaded = true;
        }

        /// <summary>
        /// Method for saving application data
        /// </summary>
        public void SaveData()
        {
            SaveItems();
        }

        /// <summary>
        /// Method for loading Items collection from isolated storage
        /// </summary>
        private void LoadItems()
        {
            try
            {
                using (IsolatedStorageFile file = IsolatedStorageFile.GetUserStoreForApplication())
                {
                    using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream("items.dat", System.IO.FileMode.OpenOrCreate, file))
                    {
                        if (stream.Length > 0)
                        {
                            DataContractSerializer serializer = new DataContractSerializer(typeof(ObservableCollection<EventViewModel>));
                            Items = serializer.ReadObject(stream) as ObservableCollection<EventViewModel>;
                        }
                    }
                }
            }
            catch (IsolatedStorageException e)
            {
                Console.WriteLine("Exception occurred when trying to read events from isolated storage: " + e.Message);
            }

        }

        /// <summary>
        /// Method for saving Items collection to isolated storage
        /// </summary>
        private void SaveItems()
        {
            try
            {
                using (IsolatedStorageFile file = IsolatedStorageFile.GetUserStoreForApplication())
                {
                    using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream("items.dat", System.IO.FileMode.Create, file))
                    {
                        DataContractSerializer serializer = new DataContractSerializer(typeof(ObservableCollection<EventViewModel>));
                        serializer.WriteObject(stream, Items);
                    }
                }
            }
            catch (IsolatedStorageException e)
            {
                Console.WriteLine("Exception occurred when trying to save events to isolated storage: " + e.Message);
            }
        }

        /// <summary>
        /// Implementation of PropertyChanged event of INotifyPropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper method for emitting PropertyChanged event
        /// </summary>
        /// <param name="propertyName">Name of the property that has changed</param>
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}