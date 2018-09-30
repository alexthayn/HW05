using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class MainViewModel
    {
        private ObservableCollection<CountryModel> _allCountries;
        private ObservableCollection<CountryModel> AllCountries
        {
            get { return _allCountries; }
            set { _allCountries = value; }
        }
        private CountryModel _selectedCountry;
    }
}
