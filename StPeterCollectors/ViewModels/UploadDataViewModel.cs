using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using StPeterCollectors.Services;
using System.Windows.Input;
using System.IO;
using StPeterCollectors.Models;

namespace StPeterCollectors.ViewModels
{
    public class UploadDataViewModel : BaseViewModel
    {
        private string _filePath;
        public string FilePath
        {
            get => _filePath;
            set { _filePath = value; OnPropertyChanged(); }
        }

        public ObservableCollection<sp_collectors_main> Records { get; set; } = new ObservableCollection<sp_collectors_main>();

        public ICommand SelectFileCommand { get; }
        public ICommand UploadCommand { get; }

        public UploadDataViewModel()
        {
            SelectFileCommand = new RelayCommand(SelectFile);
            UploadCommand = new RelayCommand(UploadData, CanUpload);
        }

        private void SelectFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Select an Excel File"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
            }
        }

        private bool CanUpload() => !string.IsNullOrEmpty(FilePath);

        private void UploadData()
        {
            if (string.IsNullOrEmpty(FilePath) || !File.Exists(FilePath))
                return;

            List<sp_collectors_main> importedRecords = ExcelImportService.ReadExcelFile(FilePath);

            using (var db = new AppDbContext())
            {
                db.sp_collectors_main.AddRange(importedRecords);
                db.SaveChanges();
            }

            Records.Clear();
            foreach (var record in importedRecords)
            {
                Records.Add(record);
            }
        }
    }
}
