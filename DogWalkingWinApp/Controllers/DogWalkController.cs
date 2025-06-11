using DogWalkingWinApp.Data;
using DogWalkingWinApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkingWinApp.ViewModel
{
    public class DogWalkController : IDogWalkController
    {
        private IDogWalkView _walkView;
        private IDogWalkListView _listView;
        private IDogWalkRepository _repository;
        public DogWalkController(IDogWalkView walkView, IDogWalkListView listView, IDogWalkRepository repository) 
        { 
            _walkView = walkView;
            _listView = listView;
            _repository = repository;

            _listView.DogWalkSelected += _listView_DogWalkSelected;
        }

        private void _listView_DogWalkSelected(object? sender, Models.DogWalk e)
        {
            _walkView.Edit(e);
        }

        public void Delete()
        {
            _walkView.Delete();
        }

        public void New()
        {
            _walkView.New();
        }

        public void Search(SearchCriteria query)
        {
            _listView.Show(_repository.Search(query));
        }

        public void Show()
        {
            _listView.Show(_repository.GetAll());
        }

        public void Save()
        {
            _walkView.Save();
        }
    }
}
