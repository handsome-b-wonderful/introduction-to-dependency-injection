using System;
using System.Runtime.Serialization;
using Pets.Common;
using Pets.DataAccess;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Pets.Presentation
{
    public class PetsViewModel : INotifyPropertyChanged
    {
        protected IPetReader DataReader;
        private IEnumerable<Pet> _pets;

        public PetsViewModel(IPetReader dataReader)
        {
            DataReader = dataReader;
            _pets = new List<Pet>();
        }

        public IEnumerable<Pet> Pets
        {
            get { return _pets; }
            set
            {
                if (_pets.Equals(value))
                    return;

                _pets = value;
                RaisePropertyChanged();
            }
        }

        public void RefreshPets()
        {
            Pets = DataReader.GetPets();
        }

        public void ClearPets()
        {
            Pets = new List<Pet>();
        }

        public string DebugDataReader
        {
            get { return DataReader.GetType().ToString(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
