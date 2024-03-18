using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListAssignment
{
    public class ToDos : INotifyPropertyChanged
    {
        public ToDos()
        {
            _allTodos = new ObservableCollection<ToDo>()
            {
                new ToDo() {Desc = "Completing the Assignment On time"},
                new ToDo() {Desc = "Early Morning Walk"},
                new ToDo() {Desc = "Meeting at 3 pm"}
            };
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private ObservableCollection<ToDo> _allTodos;
        public  ObservableCollection<ToDo> AllTodos
        {
            get { return _allTodos; }
            set
            {
                _allTodos = value;
                OnPropertyChanged(nameof(AllTodos));
            }
        }
    }
}
