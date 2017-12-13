using System;
using Microsoft.EntityFrameworkCore;
using NetStandard2.DbConnection;
using Xamarin.Forms;

namespace NetStandard2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitializeDatabase();

            MainPage = new NetStandard2Page();
        }

        private void InitializeDatabase()
        {
            SQLitePCL.Batteries.Init();
            using (var db = DbConnect.Instance.DbContext)
            {

                db.Database.EnsureCreatedAsync();
                db.Database.MigrateAsync();
            }

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
