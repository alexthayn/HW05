using Dapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SQLiteDataAccess
    {
        public const string FileName = "CountriesOfTheWorld.db";
        public string DataPath { get; private set; }
        protected string ConnectionString { get; set; }

        public SQLiteDataAccess()
        {
            DataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName);

            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder();
            builder.DataSource = DataPath;
            ConnectionString = builder.ToString();
        }

        public static ObservableCollection<CountryModel> LoadAllCountries()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<CountryModel>("select Country from 'countries of the world'", new DynamicParameters());
                return new ObservableCollection<CountryModel>(output);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            //Goes to app.config and looks for one with a name of Default (or whatever id is passed in)
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        ObservableCollection<CountryModel> Search(string searchTerm)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<CountryModel>("select Country from 'countries of the world' where name like '%"+searchTerm+"'%'", new DynamicParameters());
                return new ObservableCollection<CountryModel>(output);
            }
        }
    }
}
