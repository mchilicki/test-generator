using MatrixTransposition.UserInterface.Models;
using MatrixTransposition.UserInterface.Services;
using Microsoft.Win32;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Windows;

namespace MatrixTransposition.UserInterface.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        readonly SettingsReaderWriter _settingsReaderWriter;

        public MainWindowViewModel(
            SettingsReaderWriter settingsReaderWriter)
        {
            _settingsReaderWriter = settingsReaderWriter;
        }

        private Settings _currentSettings;

        private const string TITLE = "Matrix Transposition";
        private const string DIALOG_TEXT_FILTER = "Text files (*.txt)|*.txt";

        private string _title = TITLE;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _statusCommunicate;
        public string StatusCommunicate
        {
            get { return _statusCommunicate; }
            set { SetProperty(ref _statusCommunicate, value); }
        }

        private string _currentTestInputFileName;
        public string CurrentTestInputFileName
        {
            get { return _currentTestInputFileName; }
            set { SetProperty(ref _currentTestInputFileName, value); }
        }

        private TestInput _testInput;
        public TestInput TestInput
        {
            get { return _testInput; }
            set { SetProperty(ref _testInput, value); }
        }

        private DelegateCommand _onLoadTestInput;
        public DelegateCommand OnLoadTestInput =>
            _onLoadTestInput ?? (_onLoadTestInput = new DelegateCommand(ExecuteOnLoadTestInput));

        private DelegateCommand _onTestGenerate;
        public DelegateCommand OnTestGenerate =>
            _onTestGenerate ?? (_onTestGenerate = new DelegateCommand(ExecuteOnTestGenerate));

        void ExecuteOnLoadTestInput()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = DIALOG_TEXT_FILTER;
            if (openFileDialog.ShowDialog() == true)
            {
                //LoadMatrix(openFileDialog.FileName);
            }
        }

        void ExecuteOnTestGenerate()
        {

        }
    }
}
