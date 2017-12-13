using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetStandard2.DbConnection;
using NetStandard2.Repositories.PersonRepository;
using NetStandard2.ViewModels;
using Xamarin.Forms;

namespace NetStandard2
{
    public partial class NetStandard2Page : ContentPage
    {
        public HomeViewModel ViewModel
        {
            get;
            set;
        }

        public IPersonRepository PersonRepo
        {
            get;
            set;
        }

        public NetStandard2Page()
        {
            InitializeComponent();
            PersonRepo = new PersonRepository();
            BindingContext = ViewModel = new HomeViewModel();
            Task.Run(async () => await LoadPersons());
        
        }

        private async Task LoadPersons()
        {
            var all = await PersonRepo.GetAll();
            var names = all?.Select(s =>s.Name);

            if (names == null)
                return;

            ViewModel.Persons = new List<string>(names);
        }

        void SaveToPersonTable(object sender, System.EventArgs e)
        {
            var person = new Entities.PersonEntity()
            {
                Name = ViewModel.Name
            };
            PersonRepo.Insert(person);

            Task.Run(async () => await LoadPersons());
        }


    }
}
