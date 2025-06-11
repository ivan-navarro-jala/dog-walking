using DogWalkingWinApp.Models;
using DogWalkingWinApp.Repositories;
using DogWalkingWinApp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogWalkingWinApp.Views
{
    public partial class CtrlDogWalk : UserControl, IDogWalkView
    {
        DogWalk _dogWalk;
        IDogWalkRepository _dogWalkRepository;
        public event EventHandler<DogWalk> DogWalkSaved;

        public CtrlDogWalk(IDogWalkRepository dogWalkRepository)
        {
            InitializeComponent();
            _dogWalkRepository = dogWalkRepository;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            _dogWalk = new DogWalk();
            ResetControls();
        }

        private void ResetControls()
        {
            _txtBreed.Text = string.Empty;
            _txtClientName.Text = string.Empty;
            _txtDogName.Text = string.Empty;
            _txtPhone.Text = string.Empty;
            _numAge.Value = _numAge.Minimum;
            _numDuration.Value = _numDuration.Minimum;
            _cmbMonthsYears.SelectedIndex = 0;
            _dtpDate.Value = DateTime.Now;
            _dtpTime.Value = DateTime.Now;
        }

        public void Save()
        {
            if(!ValidateFields())
            {  
                return; 
            }

            _dogWalk.ClientName = _txtClientName.Text;
            _dogWalk.Phone = _txtPhone.Text;
            _dogWalk.DogName = _txtDogName.Text;
            _dogWalk.Breed = _txtBreed.Text;

            _dogWalk.Age = (int)_numAge.Value;
            _dogWalk.AgeSufix = _cmbMonthsYears.SelectedItem.ToString();

            _dogWalk.DateAndTime = _dtpDate.Value.Date.Add(_dtpTime.Value.TimeOfDay);
            _dogWalk.DurationInMinutes = (int)_numDuration.Value;

            try
            {
                if (_dogWalk.Id == 0)
                {
                    _dogWalkRepository.Add(_dogWalk);
                }
                else
                {
                    _dogWalkRepository.Update(_dogWalk);
                }

                DogWalkSaved(this, _dogWalk);
            }
            catch { }
        }

        private bool ValidateFields()
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(_txtClientName.Text))
            {
                errorProvider1.SetError(_txtClientName, "Client Name is required. Please enter a valid name.");
            }

            if (string.IsNullOrWhiteSpace(_txtPhone.Text))
            {
                errorProvider1.SetError(_txtPhone, "Phone number is required. Please enter a valid one.");
            }

            if (string.IsNullOrWhiteSpace(_txtDogName.Text))
            {
                errorProvider1.SetError(_txtDogName, "Dog Name is required. Please enter a valid name.");
            }

            return !errorProvider1.HasErrors;
        }

        public void Edit(DogWalk dogWalk)
        {
            _dogWalk = dogWalk;
            _txtClientName.Text = _dogWalk.ClientName;
            _txtPhone.Text = _dogWalk.Phone;
            _txtDogName.Text = _dogWalk.DogName;
            _txtBreed.Text = _dogWalk.Breed;

            _numAge.Value = _dogWalk.Age;
            _cmbMonthsYears.SelectedItem = _dogWalk.AgeSufix;

            _dtpDate.Value = _dogWalk.DateAndTime.Date;
            _dtpTime.Value = _dogWalk.DateAndTime;

            _numDuration.Value = _dogWalk.DurationInMinutes;
        }
    }
}
