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
    }
}
